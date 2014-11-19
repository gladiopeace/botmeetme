using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Threading;
using MeetMe.Properties;

namespace MeetMe
{
    public partial class frmAutoChat : DevComponents.DotNetBar.Office2007Form
    {
        #region memory
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();
        #endregion



        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetCookie(string url, string name, string data);

        public static MeetMe.Threading.Counter counter = new MeetMe.Threading.Counter();
        public static MeetMe.Threading.Counter counterTimer = new MeetMe.Threading.Counter();
        public static List<Threading.ListFriendChat> lstFriendChat = new List<Threading.ListFriendChat>();

        public static MeetMe.Threading.Counter counterMessage = new MeetMe.Threading.Counter();
        //public static List<Threading.ListFriendChat> lstFriendChat = new List<Threading.ListFriendChat>();

        List<Account> lstAccount = new List<Account>();
        Account Acc = new Account();
        public static string KetQua = "";
        public static string strLink = "";
        public static string strTen = "";
        int iCheckLogout = 0;
        int intervalTotal = 1;

        public frmAutoChat(List<Account> lstacc)
        {
            lstAccount = lstacc;
            InitializeComponent();
        }

        //public frmChat(Account acc)
        //{
        //    Acc = acc;
        //    InitializeComponent();
        //}

        private void frmChat_Load(object sender, EventArgs e)
        {
            try
            {
                if (lstAccount.Count == 0)
                {
                    return;
                }
                lblResult.Text = "";
                counter.OnCounterChanged += new EventHandler(counter_OnCounterChanged);
                counterTimer.OnCounterChanged += new EventHandler(counterTimer_OnCounterChanged);
                if (Settings.Default.TimerChat.ToString() != string.Empty)
                    intervalTotal = Settings.Default.TimerChat;
                if (Settings.Default.FileChat.ToString() != string.Empty)
                    txtPath.Text = Settings.Default.FileChat;
                intervalTotal = intervalTotal * 1000;
                TimeTotal.Interval = intervalTotal;

                StartAutoChat();

                IntPtr pHandle = GetCurrentProcess();
                SetProcessWorkingSetSize(pHandle, -1, -1);
                //this.Hide();
            }
            catch { }
        }

        #region Delete Cookies

        public void DeleteCookies()
        {
            string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (string currentFile in theCookies)
            {
                try
                {
                    System.IO.File.Delete(currentFile);
                }

                catch (Exception ex) { }
            }
        }

        #endregion

        public void counter_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.SetText(this, lblResult, KetQua);
                ThreadHelperClass.LoadListChat(this, lvFriendChat, lstFriendChat);
            }
            catch { }
        }

        public void counterTimer_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.SetTimer(this, TimeWaitting, true);
                //ThreadHelperClass.LoadListChat(this, lvFriendChat, lstFriendChat);
            }
            catch { }
        }

        public class MyThread
        {
            public string html = "";
            public string Miss = "";
            public void GetListChat()
            {
                try
                {
                    Threading.GetListAutoChat(html, ref Miss);
                    counterTimer.Count++;
                    //if (Miss == "Miss")
                    //{
                    //    MessageBox.Show("Can't get list chat.", "Error");
                    //}
                }
                catch { counterTimer.Count++; }
            }
        }

        private void lvAccount_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //UrlMessageMess = "http://messages.meetme.com/#chat/" + lvFriendChat.FocusedItem.Tag;
                //if (UrlMessageMess.IndexOf('"') >= 0)
                //    UrlMessageMess = UrlMessageMess.Split('"')[0];
                //wbMessages.Visible = false;
                //FlagStartClick = false;
                //FlagStopMess = false;
                //flagDownloadMess = false;
                //flagLoginMess = false;
                //wbMessages = new WebBrowser();
                //this.wbMessages.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMessages_DocumentCompleted);
                //wbMessages.ScriptErrorsSuppressed = true;
                //wbMessages.Navigate(UrlMessageMess);
            }
            catch { }
        }

        #region web messages
        bool FlagStopMess = false;
        bool flagLoginMess = false;
        bool flagDownloadMess = false;
        string UrlMessageMess = "";
        //string LinkChat = "http://messages.meetme.com/#chat/00000000-05a3-51e5-0000-0000000000b2";
        string urlloginMess = "http://www.meetme.com/";
        private void wbMessages_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                flagDownloadMess = true;
                if (FlagStopMess)
                {
                    wbMessages.Document.Window.ScrollTo(220, 190);
                    return;
                }
                if (flagDownloadMess)
                {
                    try
                    {
                        string html = "";
                        html = wbMessages.Document.Body.OuterHtml;
                        if (html.IndexOf("<DIV class=messages-chat-media-message-tail>") >= 0)
                        {
                            HtmlElementCollection nodeSend = wbMessages.Document.GetElementsByTagName("button");
                            foreach (HtmlElement el in nodeSend)
                            {
                                try
                                {
                                    if (el.OuterText.IndexOf("Send") >= 0)
                                    {
                                        el.OuterHtml = "<button class=\"btn btn-primary btn-sm\" style=\"HEIGHT: 23px; WIDTH: 100px; position:fixed; top : 0px; left : 0px; display: none;\" type=\"submit\">Send</button>";
                                        break;
                                    }
                                }
                                catch { }
                            }
                            wbMessages.Document.Window.ScrollTo(220, 190);
                            string Message = "";
                            if (Threading.CheckMessage(html,ref Message))
                            {
                                string Chat = "";
                                Threading.CheckMessage(txtPath.Text, Message,ref Chat);
                                Threading.SendMessage(wbMessages, Chat);
                            }
                            wbMessages.Visible = true;
                            if (FlagStartClick)
                            {
                                Current++;
                                TimeWaitting.Enabled = true;
                                TimeWaitting.Start();
                            }
                            FlagStopMess = true;
                        }
                        return;
                    }
                    catch { }
                }
            }
            catch { }
        }

        
        #endregion

        #region Web friends chat
        bool FlagStopChat = false;
        bool flagLoginChat = false;
        bool flagDownloadChat = false;
        string UrlMessageChat = "http://messages.meetme.com/";
        string urlloginChat = "http://www.meetme.com/";
        private void wbListFriendChat_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                HtmlElement NodeUserName = wbListFriendChat.Document.GetElementById("login_form_email");
                HtmlElement NodePassword = wbListFriendChat.Document.GetElementById("login_form_password");

                if (iCheckLogout == 0)
                {
                    HtmlElementCollection els = wbListFriendChat.Document.GetElementsByTagName("a");
                    foreach (HtmlElement el in els)
                    {
                        if (el.OuterHtml.IndexOf("Logout") >= 0)
                        {
                            el.InvokeMember("Click");
                            FlagStopChat = false;
                            flagDownloadChat = false;
                            break;
                        }
                    }
                    if (NodeUserName != null && NodePassword != null)
                    {
                        iCheckLogout = 1;
                        return;
                    }
                    return;
                }

                if (FlagStopChat)
                {
                    //timerChoPost.Enabled = true;
                    //timerChoPost.Start();
                    return;
                }
                if (flagDownloadChat)
                {
                    try
                    {
                        string html = "";
                        html = wbListFriendChat.Document.Body.Parent.OuterHtml;
                       if (html.IndexOf("data-id=\"") >= 0)
                       //if (html.IndexOf("media-body messages-chat-media-body-text") >= 0)
                        {
                            MyThread start = new MyThread();
                            start.html = html;
                            Thread startThread = new Thread(new ThreadStart(start.GetListChat));
                            startThread.IsBackground = true;
                            startThread.Start();

                            //media-body messages-chat-media-body-text
                            //Threading.GetListChat(html);
                            //File.WriteAllText("D:\\Application\\MyMail\\MeetMe\\MeetMe\\bin\\Debug\\Chat2.html", webBrowser1.Document.Body.Parent.OuterHtml, Encoding.GetEncoding(webBrowser1.Document.Encoding));
                            FlagStopChat = true;
                        }
                        return;
                    }
                    catch { return; }
                }

                if (NodeUserName == null && NodePassword == null)
                {
                    if (flagLoginChat == false)
                    {
                        flagLoginChat = true;
                        wbListFriendChat.Navigate(UrlMessageChat);
                        return;
                    }
                }
                else
                {
                    if (wbListFriendChat.Url.AbsoluteUri != urlloginChat)
                    {
                        wbListFriendChat.Navigate(urlloginChat);
                        return;
                    }
                    NodeUserName.InnerText = Acc.UserName;
                    NodePassword.InnerText = Acc.Password;

                    HtmlElement btn = wbListFriendChat.Document.GetElementById("login_form_submit");
                    if (btn != null)
                    {
                        flagLoginChat = false;
                        btn.InvokeMember("Click");
                        return;
                    }
                }
                if (flagLoginChat)
                {
                    if (wbListFriendChat.Url.AbsoluteUri != UrlMessageChat)
                    {
                        wbListFriendChat.Navigate(UrlMessageChat);
                        return;
                    }
                    string html = wbListFriendChat.DocumentText;
                    flagDownloadChat = true;
                }
            }
            catch { }
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection els = wbMessages.Document.GetElementsByTagName("button");
                foreach (HtmlElement el in els)
                {
                    if (el.OuterText.IndexOf("Refresh") >= 0)
                    {
                        el.InvokeMember("Click");
                        break;
                    }
                }
            }
            catch { }
        }

        int Current = 0;
        bool FlagStartClick = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Trim() == "")
                {
                    MessageBox.Show("Please select file chat.", "Message");
                    frmSetting frm = new frmSetting();
                    frm.ShowDialog();
                    //txtPath.Text = 
                    return;
                }
                lblResult.Text = "Loading message, Please waiting...";
                btnStart.Enabled = false;
                txtPath.Enabled = false;
                Current = 0;
                CurrentTotal = 0;
                FlagStartClick = true;
                //TimeWaitting.Enabled = true;
                //TimeWaitting.Start();
                TimeTotal.Interval = intervalTotal;
                TimeTotal.Enabled = true;
                TimeTotal.Start();
            }
            catch { }
        }

        public void StartAutoChat()
        {
            try
            {
                if (txtPath.Text.Trim() == "")
                {
                    MessageBox.Show("Please select file chat.", "Message");
                    frmSetting frm = new frmSetting();
                    frm.ShowDialog();
                    txtPath.Text = Settings.Default.FileChat.ToString();
                }
                txtPath.Text = Settings.Default.FileChat.ToString();
                lblResult.Text = "Loading message, Please waiting...";
                btnStart.Enabled = false;
                txtPath.Enabled = false;
                Current = 0;
                CurrentTotal = 0;
                FlagStartClick = true;
                //TimeWaitting.Enabled = true;
                //TimeWaitting.Start();
                TimeTotal.Interval = 5000;
                TimeTotal.Enabled = true;
                TimeTotal.Start();
            }
            catch { }
        }

        private void TimeWaitting_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.TimerChat.ToString() != string.Empty)
                    intervalTotal = Settings.Default.TimerChat * 1000;
                TimeWaitting.Enabled = false;
                TimeWaitting.Stop();
                if (Current >= lvFriendChat.Items.Count)
                {
                    //lblResult.Text = "Completion.";
                    //return;
                    CurrentTotal++;
                    TimeTotal.Interval = intervalTotal;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }

                FlagStopMess = false;
                flagDownloadMess = false;
                flagLoginMess = false;

                string tag = lvFriendChat.Items[Current].Tag.ToString();
                lblResult.Text = Acc.UserName + " - " + lvFriendChat.Items[Current].Name;

                IntPtr pHandle = GetCurrentProcess();
                SetProcessWorkingSetSize(pHandle, -1, -1);

                wbMessages = new WebBrowser();

                this.wbMessages.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMessages_DocumentCompleted);
                wbMessages.ScriptErrorsSuppressed = true;

                UrlMessageMess = "http://messages.meetme.com/#chat/" + tag;
                if (UrlMessageMess.IndexOf('"') >= 0)
                    UrlMessageMess = UrlMessageMess.Split('"')[0];
                wbMessages.Visible = false;
                
                wbMessages.Navigate(UrlMessageMess);
            }
            catch
            {
                //lblResult.Text = "Completion.";
                CurrentTotal++;
                TimeTotal.Enabled = true;
                TimeTotal.Start();
            }
        }

        int CurrentTotal = 0;
        private void TimeTotal_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeTotal.Enabled = false;
                TimeTotal.Stop();
                lvFriendChat.Items.Clear();
                lstFriendChat = new List<Threading.ListFriendChat>();
                Current = 0;
                iCheckLogout = 0;

                FlagStopMess = false;
                flagDownloadMess = false;
                flagLoginMess = false;

                Acc = lstAccount[CurrentTotal];
                wbListFriendChat.Navigate("http://meetme.com");
            }
            catch { 
                lblResult.Text = "Completion.";
                txtPath.Enabled = true; 
                btnStart.Enabled = true;
                //xong, chạy lại
                StartAutoChat();
            }
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sFile = new OpenFileDialog();
                sFile.Filter = "All Files *.*|*.*";
                sFile.InitialDirectory = Application.StartupPath;
                DialogResult dialogResult = sFile.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    txtPath.Text = sFile.FileName;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
