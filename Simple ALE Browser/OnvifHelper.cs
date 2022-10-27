using Simple_ALE_Browser.OnvifMedia2;
using Simple_ALE_Browser.OnvifDeviceMgmt10;
using System.Net;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Linq;

namespace Simple_ALE_Browser
{
    class OnvifHelper
    {
        public static string GetONVIFSnapshotURI(string _dsAddress, string _usr, string _pwd, int _profileNumber)
        {

            // References:
            // SO 1: https://stackoverflow.com/questions/32779467/onvif-api-capture-image-in-c-sharp
            // SO 2:
            // Bullet-Time-ONVIF: https://github.com/mrrekcuf/Bullet-Time-ONVIF             


            // Required to prevent 417 Expectation Failed error

            ServicePointManager.Expect100Continue = false;
            
            var msgElement = new TextMessageEncodingBindingElement();
            msgElement.MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None);

            // Initial binding for posting to device_service, with Digest authentication
            HttpTransportBindingElement bindElement = new HttpTransportBindingElement();
            bindElement.AuthenticationScheme = AuthenticationSchemes.Digest; 
            CustomBinding customBind = new CustomBinding(msgElement, bindElement);

            // Create a new Device, the get the list of available service.
            DeviceClient device = new DeviceClient(customBind, new EndpointAddress(_dsAddress));

            Service[] services = device.GetServices(false);
            
            // Then, find the Media related service by LINQ call

            Service media = services.FirstOrDefault(s => s.Namespace == "http://www.onvif.org/ver20/media/wsdl");

            Media2Client sabM2Client = new Media2Client(customBind, new EndpointAddress(media.XAddr));

            sabM2Client.ClientCredentials.HttpDigest.ClientCredential.UserName = _usr;
            sabM2Client.ClientCredentials.HttpDigest.ClientCredential.Password = _pwd;
            sabM2Client.ClientCredentials.HttpDigest.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            // Finally get a list of capabilities from this device.
            // For this, we are interested in if SnapshotUri is true

            Capabilities2 cap2 = sabM2Client.GetServiceCapabilities();

            if (cap2.SnapshotUri)
            {
                // Get list of profiles, then select the one provided by default

                MediaProfile[] profiles = sabM2Client.GetProfiles(null, null);
                string _uri = sabM2Client.GetSnapshotUri(profiles[_profileNumber].token);
                return _uri;
            }
            else
            {
                return "NA";
            }

        }

        public static MemoryStream DownloadSnapshot(string _uri, string _onvifuser, string _onvifpassword)
        {
            WebClient _wc = new WebClient();
            _wc.Credentials = new NetworkCredential(_onvifuser, _onvifpassword);
            MemoryStream _ms = new MemoryStream(_wc.DownloadData(_uri));
            return _ms;
        }
    }
}
