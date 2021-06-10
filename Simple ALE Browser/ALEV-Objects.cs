using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ALE_Browser
{
    public class UserList
    {
        public string UserName { get; set; }
    }
    
    public class UserAuditResult
    {
        public DateTime ActionTimeLocal { get; set; }
        public string ComputerName { get; set; }
        public string Information { get; set; }
    }
}
