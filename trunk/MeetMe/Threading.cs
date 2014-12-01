using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using HtmlAgilityPack;

namespace MeetMe
{
    public class Threading
    {
        public static List<Friend> lstFriend = new List<Friend>();
        public static List<Friend> lstRequestAddFriend = new List<Friend>();
        public static List<ListFriendChat> lstChat = new List<ListFriendChat>();
        
        #region Login
        public static bool Login(Account account, DataGridView grid, int Current)
        {
            try
            {
                string urlLogin = account.UrlLogin;//Move to login page 
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(urlLogin);
                account.Cookie = "";
                string value = "username=" + account.UserName
                                + "&password=" + account.Password
                                + "&securitytoken=guest"
                                + "&register=0"
                                + "&cookieuser=1"
                                + "&do=login";

                wReq.Referer = urlLogin;
                wReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.11 (KHTML, like Gecko) Chrome/17.0.963.79 Safari/535.11";
                wReq.Method = "POST";
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.ContentLength = value.Length;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";

                WebProxy proxyObject = new WebProxy(account.Proxy, int.Parse(account.Port));
                // Disable proxy use when the host is local.
                proxyObject.BypassProxyOnLocal = true;
                // HTTP requests use this proxy information.
                GlobalProxySelection.Select = proxyObject;

                CookieContainer cookContainer = new CookieContainer();
                wReq.CookieContainer = cookContainer;
                ServicePointManager.Expect100Continue = false;
                account.CookieContainer = wReq.CookieContainer;

                using (StreamWriter writer = new StreamWriter(wReq.GetRequestStream(), Encoding.ASCII))
                {
                    writer.Write(value);
                }

                HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                StreamReader reader = new StreamReader(wRes.GetResponseStream());
                string responseStream = reader.ReadToEnd();
                reader.Close();
                foreach (Cookie c in wRes.Cookies)
                {
                    account.Cookie = account.Cookie + c.ToString() + ";";
                    account.CookieContainer.Add(c);
                }
                Main.lstAcc.Add(account);
                if (responseStream.IndexOf("/profile.meetme.com/views") >= 0)
                {
                    grid.Rows[Current].Cells["grdColStatus"].Value = "OK";
                    account.Login = true;
                    Main.counterLogin.Count++;
                    return true;
                }

                int pos = account.Cookie.IndexOf("userid");
                if (pos > 0)
                {
                    grid.Rows[Current].Cells["grdColStatus"].Value = "OK";
                    account.Login = true;
                    Main.counterLogin.Count++;
                    return true;
                }
                int pos2 = account.Cookie.IndexOf("MYB_TARGET");
                if (pos2 > 0)
                {
                    grid.Rows[Current].Cells["grdColStatus"].Value = "OK";
                    account.Login = true;
                    Main.counterLogin.Count++;
                    return true;
                }
                account.Login = false;
                Main.counterLogin.Count++;
                grid.Rows[Current].Cells["grdColStatus"].Value = "";
                //grid.Rows.RemoveAt(Current);
                return false;
                //else
                //    return ReCheckLogin(account);
            }
            catch (Exception ex)
            {
                account.Login = false;
                Main.counterLogin.Count++;
                grid.Rows[Current].Cells["grdColStatus"].Value = "Error";
                return false;
            }
        }

        public static bool ReCheckLogin(Account account)
        {
            try
            {
                int pos = -1;
                int dest = -1;
                string url = account.UrlLogin;
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                WebProxy proxyObject = new WebProxy(account.Proxy, int.Parse(account.Port));
                // Disable proxy use when the host is local.
                proxyObject.BypassProxyOnLocal = true;
                // HTTP requests use this proxy information.
                GlobalProxySelection.Select = proxyObject;

                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;

                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();
                    reader.Close();
                    pos = responseStream.IndexOf("do=logout");
                    if (pos > 0)
                        return true;
                    else
                    {
                        try
                        {
                            pos = responseStream.IndexOf("id=\"wgo_onlineusers_list\"");
                            dest = responseStream.IndexOf("id=\"wgo_wvt_users\"");
                            string temp = responseStream.Substring(pos, dest - pos);
                            int pos1 = temp.IndexOf(account.UserName);
                            if (pos1 > 0)
                                return true;
                        }
                        catch { }
                    }
                    //int pos = responseStream.IndexOf("var SECURITYTOKEN = \"");
                    //string tem = responseStream.Substring(pos, 128);
                    //securityToken = tem.Substring(21, 51);
                    wRes.Close();
                }
                catch
                {
                }

                return false;
            }
            catch
            { return false; }
        }
        #endregion

        #region GetProfile + ClickAcceptFriend
        public static bool GetProfile(Account account, ref string Ten,ref string Tuoi,ref string GioiTinh,ref string TinhTrangHonNhan,ref string ThanhPho,ref string KhuVuc,ref string QuocGia)
        {
            try
            {
                string url = account.UrlProfile;
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;
                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();
                    #region GetInfor
                    int SoKyTu = 0;
                    int startName = responseStream.IndexOf("<span class=\"profileName\">");
                    string strChuoiTam = responseStream.Substring(startName, responseStream.Length - startName);
                    Ten = GetSubString(strChuoiTam, "<span class=\"profileName\">", "</span>", ref SoKyTu);

                    int startAge = strChuoiTam.IndexOf("<span class=\"age\">");
                    if (startAge >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startAge, strChuoiTam.Length - startAge);
                        Tuoi = GetSubString(strChuoiTam, "<span class=\"age\">", "</span>", ref SoKyTu);
                    }

                    int startSex = strChuoiTam.IndexOf("<span id=\"divGender\" class=\"gender\">");
                    if (startSex >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startSex, strChuoiTam.Length - startSex);
                        GioiTinh = GetSubString(strChuoiTam, "<span id=\"divGender\" class=\"gender\">", "</span>", ref SoKyTu);
                    }

                    int startHonNhan = strChuoiTam.IndexOf("<span id=\"divRelationshipStatus\" class=\"relationshipStatus\">");
                    if (startHonNhan >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startHonNhan, strChuoiTam.Length - startHonNhan);
                        TinhTrangHonNhan = GetSubString(strChuoiTam, "<span variant=\"1\">", "</span>", ref SoKyTu);
                    }

                    int startCityTemp = strChuoiTam.IndexOf("<span id=\"divCity\" class=\"city \">");
                    if (startCityTemp >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startCityTemp, strChuoiTam.Length - startCityTemp);
                        int startCity = strChuoiTam.IndexOf("<a href=\"/?");
                        if (startCity >= 0)
                        {
                            strChuoiTam = strChuoiTam.Substring(startCity, strChuoiTam.Length - startCity);
                            ThanhPho = GetSubString(strChuoiTam, ">", "</a>", ref SoKyTu);
                        }
                    }

                    int startStateTemp = strChuoiTam.IndexOf("<span id=\"divState\" class=\"state \">");
                    if (startStateTemp >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startStateTemp, strChuoiTam.Length - startStateTemp);
                        int startState = strChuoiTam.IndexOf("<a href=\"/?");
                        if (startState >= 0)
                        {
                            strChuoiTam = strChuoiTam.Substring(startState, strChuoiTam.Length - startState);
                            KhuVuc = GetSubString(strChuoiTam, ">", "</a>", ref SoKyTu);
                        }
                    }

                    int startCountryTemp = strChuoiTam.IndexOf("<span id=\"divCountry\" class=\"country \">");
                    if (startCountryTemp >= 0)
                    {
                        strChuoiTam = strChuoiTam.Substring(startCountryTemp, strChuoiTam.Length - startCountryTemp);
                        int startCountry = strChuoiTam.IndexOf("<a href=\"/?");
                        if (startCountry >= 0)
                        {
                            strChuoiTam = strChuoiTam.Substring(startCountry, strChuoiTam.Length - startCountry);
                            QuocGia = GetSubString(strChuoiTam, ">", "</a>", ref SoKyTu);
                        }
                    }
                    #endregion
                    reader.Close();
                    wRes.Close();
                }
                catch { }
                return false;
            }
            catch { return false; }
        }
        public static bool ClickAccept(Account account, string IdFirend)
        {
            try
            {
                string urlRequest = account.UrlGetFriendRequest;
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(urlRequest);
                string value = "actionArr[" + IdFirend + "]=accept&page=1&requestMethod=json";

                wReq.Referer = urlRequest;
                wReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.11 (KHTML, like Gecko) Chrome/17.0.963.79 Safari/535.11";
                wReq.Method = "Post";
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.ContentLength = value.Length;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.CookieContainer = account.CookieContainer;
                ServicePointManager.Expect100Continue = false;
                account.CookieContainer = wReq.CookieContainer;

                using (StreamWriter writer = new StreamWriter(wReq.GetRequestStream(), Encoding.ASCII))
                {
                    writer.Write(value);
                }

                HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                StreamReader reader = new StreamReader(wRes.GetResponseStream());
                string responseStream = reader.ReadToEnd();
                reader.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Get Friends
        public static bool GetRequestAddFriends(Account account, ref string Link, ref string Ten, ref string KQ)
        {
            try
            {
                //string Link = "";
                //string Ten = "";
                lstRequestAddFriend = new List<Friend>();
                string url = account.UrlGetFriendRequest;
               
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;
                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();

                    #region GetInfor
                    int SoKyTu = 0;
                    int startStep = responseStream.IndexOf("<div id=\"searchApplication\">");
                    string strChuoiTam = responseStream.Substring(startStep, responseStream.Length - startStep);
                    int iKQ = 0;
                    while (SoKyTu >= 0 && strChuoiTam != "")
                    {
                        try
                        {
                            SoKyTu = 0;
                            strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<div class=\"info\">"));
                            Link = GetSubString(strChuoiTam, "href=\"", "\" data-member-id=", ref SoKyTu).ToLower().Trim();
                            Ten = GetSubString(strChuoiTam, "<span data-search=\"name\" class=\"\">", "</span>", ref SoKyTu).ToLower().Trim();
                            iKQ++;
                            Friend fr = new Friend();
                            fr.Ten = Ten;
                            fr.Link = Link;
                            lstRequestAddFriend.Add(fr);
                            frmRequest.lstRequestAddFriend = lstRequestAddFriend;
                            KQ = iKQ.ToString(); 
                            startStep = strChuoiTam.IndexOf("div class=\"info\">");
                            strChuoiTam = strChuoiTam.Substring(startStep, strChuoiTam.Length - startStep);
                        }
                        catch { SoKyTu = -1; }
                    }
                    if (KQ.Trim() == "0" || KQ.Trim() == "")
                        KQ = "No friend requests!";
                    frmRequest.KetQua = KQ;
                    frmRequest.counter.Count++;
                    #endregion
                    
                    reader.Close();
                    wRes.Close();
                }
                catch { }
                return false;
            }
            catch { return false; }
        }

        public static bool GetRequestFriends(Account account, ref string Link, ref string Ten, ref string KQ)
        {
            try
            {
                lstFriend = new List<Friend>();
                string url = account.UrlFriend;
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;
                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();

                    #region GetInfor
                    int SoKyTu = 0;
                    int startStep = responseStream.IndexOf("<div id=\"searchResults\">");
                    string strChuoiTam = responseStream.Substring(startStep, responseStream.Length - startStep);
                    int iKQ = 0;
                    while (SoKyTu >= 0 && strChuoiTam != "")
                    {
                        try
                        {
                            SoKyTu = 0;
                            strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<div class=\"simple\">"));
                            Link = GetSubString(strChuoiTam, "href=\"", "\" data-search=\"profileLink\"", ref SoKyTu).ToLower().Trim();
                            Ten = GetSubString(strChuoiTam, "<span data-search=\"name\" class=\"\">", "</span>", ref SoKyTu).ToLower().Trim();
                            iKQ++;
                            Friend fr = new Friend();
                            fr.Ten = Ten;
                            fr.Link = Link;
                            lstFriend.Add(fr);
                            KQ = iKQ.ToString();
                            startStep = strChuoiTam.IndexOf("div class=\"simple\">");
                            strChuoiTam = strChuoiTam.Substring(startStep, strChuoiTam.Length - startStep);
                        }
                        catch { SoKyTu = -1; }
                    }
                    if (KQ.Trim() == "0" || KQ.Trim() == "")
                        KQ = "No Friends Found!";
                    else
                        KQ += " Friends";

                    frmRequest.lstFd = lstFriend;
                    frmRequest.KetQua = KQ;
                    frmRequest.counterfriend.Count++;
                    #endregion

                    reader.Close();
                    wRes.Close();
                }
                catch { }
                return false;
            }
            catch { return false; }
        }

        public static bool GetAutoRequestAddFriends(Account account, ref string Link, ref string Ten, ref string KQ)
        {
            try
            {
                //string Link = "";
                //string Ten = "";
                lstRequestAddFriend = new List<Friend>();
                string url = account.UrlGetFriendRequest;

                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;
                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();

                    #region GetInfor
                    int SoKyTu = 0;
                    int startStep = responseStream.IndexOf("<div id=\"searchApplication\">");
                    string strChuoiTam = responseStream.Substring(startStep, responseStream.Length - startStep);
                    int iKQ = 0;
                    while (SoKyTu >= 0 && strChuoiTam != "")
                    {
                        try
                        {
                            SoKyTu = 0;
                            strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<div class=\"info\">"));
                            Link = GetSubString(strChuoiTam, "href=\"", "\" data-member-id=", ref SoKyTu).ToLower().Trim();
                            Ten = GetSubString(strChuoiTam, "<span data-search=\"name\" class=\"\">", "</span>", ref SoKyTu).ToLower().Trim();
                            iKQ++;
                            Friend fr = new Friend();
                            fr.Ten = Ten;
                            fr.Link = Link;
                            lstRequestAddFriend.Add(fr);
                            frmAutoRequest.lstRequestAddFriend = lstRequestAddFriend;
                            KQ = iKQ.ToString();
                            startStep = strChuoiTam.IndexOf("div class=\"info\">");
                            strChuoiTam = strChuoiTam.Substring(startStep, strChuoiTam.Length - startStep);
                        }
                        catch { SoKyTu = -1; }
                    }
                    if (KQ.Trim() == "0" || KQ.Trim() == "")
                        KQ = "No friend requests!";
                    frmAutoRequest.KetQua = KQ;
                    frmAutoRequest.counter.Count++;
                    #endregion

                    reader.Close();
                    wRes.Close();
                }
                catch { }
                return false;
            }
            catch { return false; }
        }

        public static bool GetAutoRequestFriends(Account account, ref string Link, ref string Ten, ref string KQ)
        {
            try
            {
                if (frmAutoRequest.StopAllRequest == 1)
                    return false;
                lstFriend = new List<Friend>();
                string url = account.UrlFriend;
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);

                wReq.UserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-US) AppleWebKit/533.11 (KHTML, like Gecko) Chrome/5.0.375.70 Safari/533.11";
                wReq.Method = "GET";
                wReq.KeepAlive = true;
                wReq.ContentType = "application/x-www-form-urlencoded";
                wReq.CookieContainer = account.CookieContainer;
                wReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8, */*";
                wReq.AllowAutoRedirect = true;
                try
                {
                    HttpWebResponse wRes = (HttpWebResponse)wReq.GetResponse();
                    StreamReader reader = new StreamReader(wRes.GetResponseStream());
                    string responseStream = reader.ReadToEnd();

                    #region GetInfor
                    int SoKyTu = 0;
                    int startStep = responseStream.IndexOf("<div id=\"searchResults\">");
                    string strChuoiTam = responseStream.Substring(startStep, responseStream.Length - startStep);
                    int iKQ = 0;
                    while (SoKyTu >= 0 && strChuoiTam != "")
                    {
                        try
                        {
                            SoKyTu = 0;
                            strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<div class=\"simple\">"));
                            Link = GetSubString(strChuoiTam, "href=\"", "\" data-search=\"profileLink\"", ref SoKyTu).ToLower().Trim();
                            Ten = GetSubString(strChuoiTam, "<span data-search=\"name\" class=\"\">", "</span>", ref SoKyTu).ToLower().Trim();
                            iKQ++;
                            Friend fr = new Friend();
                            fr.Ten = Ten;
                            fr.Link = Link;
                            lstFriend.Add(fr);
                            KQ = iKQ.ToString();
                            startStep = strChuoiTam.IndexOf("div class=\"simple\">");
                            strChuoiTam = strChuoiTam.Substring(startStep, strChuoiTam.Length - startStep);
                        }
                        catch { SoKyTu = -1; }
                    }
                    if (KQ.Trim() == "0" || KQ.Trim() == "")
                        KQ = "No Friends Found!";
                    else
                        KQ += " Friends";

                    frmAutoRequest.lstFd = lstFriend;
                    frmAutoRequest.KetQua = KQ;
                    frmAutoRequest.counterfriend.Count++;
                    #endregion

                    reader.Close();
                    wRes.Close();
                }
                catch { }
                return false;
            }
            catch { return false; }
        }
        #endregion

        #region GetListChat + GetChat

        public static void GetListAutoChat(string html,ref string Miss)
        {
            try
            {
                Miss = "";
                string Link = "";
                string Name = "";
                string Day = "";
                string LinkPic = "";
                string Content = "";
                string KQ = "";
                lstChat = new List<ListFriendChat>();
                int SoKyTu = 0;
                int startStep = html.IndexOf("<UL class=\"media-list media-list-messages-chats\">");
                string strChuoiTam = html.Substring(startStep, html.Length - startStep);
                int iKQ = 0;
                while (SoKyTu >= 0 && strChuoiTam != "")
                {
                    try
                     {
                        SoKyTu = 0;
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<LI class=\"media media-member"));
                        Link = GetSubString(strChuoiTam, "data-id=\"", "\"><A", ref SoKyTu).Trim();
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<IMG"), strChuoiTam.Length - strChuoiTam.IndexOf("<IMG"));

                        LinkPic = GetSubString(strChuoiTam, "src=\"", "\">", ref SoKyTu).Trim();
                        Name = GetSubString(strChuoiTam, "<H5 class=media-heading>", "</H5>", ref SoKyTu).Trim();
                        if(Name.IndexOf("</SPAN>")>=0)
                            Name = GetSubString(strChuoiTam, "</SPAN>", "</H5>", ref SoKyTu).Trim();
                        //title="
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<DIV class=media-date>"), strChuoiTam.Length - strChuoiTam.IndexOf("<DIV class=media-date>"));
                        Day = GetSubString(strChuoiTam, "<DIV class=media-date>", "</DIV>", ref SoKyTu).Trim();
                        Content = GetSubString(strChuoiTam, "<P>", "</P>", ref SoKyTu).Trim();
                        iKQ++;
                        ListFriendChat lc = new ListFriendChat();
                        lc.Content = Content;
                        lc.Day = Day;
                        lc.Link = Link;
                        lc.LinkPic = LinkPic;
                        lc.Name = Name;
                        lstChat.Add(lc);
                        KQ = iKQ.ToString();
                    }
                    catch { SoKyTu = -1; }
                }
                if (KQ.Trim() == "0" || KQ.Trim() == "")
                    KQ = "No messages!";
                else
                    KQ += " Messages";

                frmAutoChat.lstFriendChat = lstChat;
                frmAutoChat.KetQua = KQ;
                frmAutoChat.counter.Count++;
            }
            catch { Miss = "Miss"; }
        }
        public static void GetListChat(string html,ref string Miss)
        {
            try
            {
                Miss = "";
                string Link = "";
                string Name = "";
                string Day = "";
                string LinkPic = "";
                string Content = "";
                string KQ = "";
                lstChat = new List<ListFriendChat>();
                int SoKyTu = 0;
                int startStep = html.IndexOf("<UL class=\"media-list media-list-messages-chats\">");
                string strChuoiTam = html.Substring(startStep, html.Length - startStep);
                int iKQ = 0;
                while (SoKyTu >= 0 && strChuoiTam != "")
                {
                    try
                     {
                        SoKyTu = 0;
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<LI class=\"media media-member"));
                        Link = GetSubString(strChuoiTam, "data-id=\"", "\"><A", ref SoKyTu).Trim();
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<IMG"), strChuoiTam.Length - strChuoiTam.IndexOf("<IMG"));

                        LinkPic = GetSubString(strChuoiTam, "src=\"", "\">", ref SoKyTu).Trim();
                        Name = GetSubString(strChuoiTam, "<H5 class=media-heading>", "</H5>", ref SoKyTu).Trim();
                        if(Name.IndexOf("</SPAN>")>=0)
                            Name = GetSubString(strChuoiTam, "</SPAN>", "</H5>", ref SoKyTu).Trim();
                        //title="
                        strChuoiTam = strChuoiTam.Substring(strChuoiTam.IndexOf("<DIV class=media-date>"), strChuoiTam.Length - strChuoiTam.IndexOf("<DIV class=media-date>"));
                        Day = GetSubString(strChuoiTam, "<DIV class=media-date>", "</DIV>", ref SoKyTu).Trim();
                        Content = GetSubString(strChuoiTam, "<P>", "</P>", ref SoKyTu).Trim();
                        iKQ++;
                        ListFriendChat lc = new ListFriendChat();
                        lc.Content = Content;
                        lc.Day = Day;
                        lc.Link = Link;
                        lc.LinkPic = LinkPic;
                        lc.Name = Name;
                        lstChat.Add(lc);
                        KQ = iKQ.ToString();
                    }
                    catch { SoKyTu = -1; }
                }
                if (KQ.Trim() == "0" || KQ.Trim() == "")
                    KQ = "No messages!";
                else
                    KQ += " Messages";

                frmChat.lstFriendChat = lstChat;
                frmChat.KetQua = KQ;
                frmChat.counter.Count++;
                
            }
            catch { Miss = "Miss"; }
        }

        public static bool CheckMessage(string html,ref string Message)
        {
            try
            {
                int Start = html.IndexOf("<LI class=\"media messages-chat-media-");
                string strChuoiTam = html.Substring(Start, html.Length - Start);
                int Startli = 0;
                string li = "";
                while (Startli != -1)
                {
                    try
                    {
                        Startli = strChuoiTam.IndexOf("<LI class=\"media messages-chat-media-");
                        int Endli = strChuoiTam.IndexOf("</LI>");
                        li = strChuoiTam.Substring(Startli, Endli - Startli);
                        strChuoiTam = strChuoiTam.Substring(Endli + 1, strChuoiTam.Length - Endli - 1);
                    }
                    catch {}
                }
                if (li.IndexOf("<LI class=\"media messages-chat-media-them\">") >= 0)
                {
                    try
                    {
                        int start = li.IndexOf("<P>");
                        int end = li.IndexOf("</P>");
                        if (start != -1 && end != -1)
                        {
                            Message = li.Substring(start + 3, end - start - 3).Trim();
                            return true;
                        }
                        else
                        {
                            Message = "";
                            return false;
                        }
                    }
                    catch { return false; }
                }
                else
                    return false;
            }
            catch { return false; }
        }

        public static void CheckMessage(string Path,string Message, ref string Chat)
        {
            try
            {
                using (var reader = new StreamReader(Path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            string[] LINE = line.Split(':');
                            if (LINE.Length > 1)
                            {
                                string Question = LINE[0].ToString().Trim();
                                if (Question.ToLower().Equals(Message.ToLower()))
                                {
                                    Chat = LINE[1].ToString().Trim();
                                    break;
                                }
                            }

                        }
                        catch { Chat = ""; }
                    }
                    if (Chat == "")
                    {
                        Chat = ":)";
                    }
                }
            }
            catch { Chat = ""; }
        }

        public static void SendMessage(WebBrowser wb, string text)
        {
            try
            {
                HtmlElementCollection els = wb.Document.GetElementsByTagName("textarea");
                if (els != null)
                {
                    HtmlElement elm = els[0];
                    elm.InnerText = text;
                }

                HtmlElementCollection nodeSend = wb.Document.GetElementsByTagName("button");
                foreach (HtmlElement el in nodeSend)
                {
                    try
                    {
                        if (el.OuterText.IndexOf("Send") >= 0)
                        {
                            el.InvokeMember("Click");
                            break;
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }

        #endregion

        #region properties
        public static string GetSubString(string Text, string StringStart, string StringEnd, ref int SoKyTu)
        {
            try
            {
                int vt1, vt2;
                string t1 = Text, t2 = "";
                StringStart = StringStart.ToLower();
                StringEnd = StringEnd.ToLower();
                vt1 = Text.ToLower().IndexOf(StringStart);
                try
                {
                    if (vt1 >= 0)
                    {
                        t1 = t1.Substring(vt1 + StringStart.Length);
                        vt2 = t1.ToLower().IndexOf(StringEnd);
                        if (vt2 >= 0)
                        {
                            t2 += t1.Substring(0, vt2);
                            vt1 = t1.ToLower().IndexOf(StringStart);
                        }
                        else
                            vt1 = -1;
                    }
                }
                catch { }
                SoKyTu = vt1;
                return t2;
            }
            catch { return ""; }
        }

        public class Counter
        {
            public event EventHandler OnCounterChanged;
            private int count;
            public int Count
            {
                get
                {
                    return count;
                }
                set
                {
                    count = value;

                    if (OnCounterChanged != null)
                    {
                        OnCounterChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public class Friend
        {
            public string Ten { get; set; }
            public string Link { get; set; }
            public Friend()
            { }
        }

        public class ListFriendChat
        {
            public string Link { get; set; }
            public string Name { get; set; }
            public string LinkPic { get; set; }
            public string Day { get; set; }
            public string Content { get; set; }
            public ListFriendChat() { }
        }

        public class Message
        {
            
        }

        public class MyUser
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Pass { get; set; }
            public string Proxy { get; set; }
            public string Port { get; set; }
            public MyUser() { }
        }
        #endregion


    }
}
