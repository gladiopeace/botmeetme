using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MeetMe
{
    public class Account
    {
        public string UrlProfile { get; set; }
        public string UrlGetFriendRequest { get; set; }
        public string UrlFriend { get; set; }
        public string UrlLogin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Proxy { get; set; }
        public string Port { get; set; }
        public CookieContainer CookieContainer { get; set; }
        public string Cookie { get; set; }
        public Int32 ID { get; set; }
        public bool Login { get; set; }
    }
}
