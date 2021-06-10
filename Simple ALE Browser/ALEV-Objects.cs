using System;

namespace Simple_ALE_Browser
{
    public class UserList
    {
        public string UserName { get; set; }
    }
    
    public class UserAuditResult
    {
        public string ActionDateLocal { get; set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string Information { get; set; }
    }
}
