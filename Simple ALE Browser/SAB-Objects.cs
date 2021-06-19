using System;
using System.Net;

namespace Simple_ALE_Browser
{
    public class AlevUser
    {
        public string UserName { get; set; }
    }

    public class AlevCC
    {
        public string ComputerName { get; set; }        
    }

    public class AlevAction
    {
        public AlevAction(string _desc, int _id1, int _id2, int _id3)
        {
            Description = _desc;
            ActionId_1 = _id1;
            ActionId_2 = _id2;
            ActionId_3 = _id3;            
            InString = string.Format("({0},{1},{2})", _id1, _id2, _id3);
            DisplayText = string.Format("{0} {1}", _desc, InString);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1},{2},{3})", Description, ActionId_1, ActionId_2, ActionId_3);
        }

        public string Description { get; set; }
        public int ActionId_1 { get; set; }
        public int ActionId_2 { get; set; }
        public int ActionId_3 { get; set; }
        public string InString { get; set; }
        public string DisplayText { get; set; }
    }

    public class AlevCamIp
    {
        public int SourceIp { get; set; }
    }    

    public class UserAuditResult
    {
        public string ActionDateLocal { get; set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string ObjectName { get; set; }
        public string Information { get; set; }
        public int SourceIp { get; set; }     
        public int ActionId { get; set; }
        public int Total { get; set; }
        public IPAddress ConvertedIP { get; set; }
    }

    public class SABSettings
    {
        public bool IsConfigured { get; set; }
        public string ServerName { get; set; }
        public string InstanceName { get; set; }
        public string DatabaseName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string OnvifLogin { get; set; }
        public string OnvifPassword { get; set; }
    }
}
