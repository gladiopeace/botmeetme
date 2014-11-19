using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MeetMe.Properties;

namespace MeetMe
{
    public partial class frmAutoRequest : DevComponents.DotNetBar.Office2007Form
    {
        public static MeetMe.Threading.Counter counter = new MeetMe.Threading.Counter();
        public static MeetMe.Threading.Counter counterfriend = new MeetMe.Threading.Counter();
        public static List<Threading.Friend> lstFd = new List<Threading.Friend>();
        public static List<Threading.Friend> lstRequestAddFriend = new List<Threading.Friend>();
        List<Account> lstAccount = new List<Account>();
        Account Acc = new Account();
        public static string KetQua = "";
        public static string strLink = "";
        public static string strTen = "";
        bool StopAll = false;

        public frmAutoRequest(List<Account> lstacc)
        {
            lstAccount = lstacc;
            InitializeComponent();
        }

        private void frmRequests_Load(object sender, EventArgs e)
        {
            try
            {
                if (lstAccount.Count == 0)
                {
                    return;
                }
                counter.OnCounterChanged += new EventHandler(counter_OnCounterChanged);
                counterfriend.OnCounterChanged += new EventHandler(counterfriend_OnCounterChanged);
                if (Settings.Default.TimerAddFriend.ToString() != string.Empty)
                    nupPause.Value = Settings.Default.TimerAddFriend;
                StartAutoAddFriend();
                //this.Hide();
            }
            catch { }
        }

        public void LoadRequestAddFriend()
        {
            try
            {
                MyThread start = new MyThread();
                start.KQ = "";
                Acc.UrlGetFriendRequest = "http://friends.meetme.com/friendrequests";
                start.account = Acc;
                Thread startThread = new Thread(new ThreadStart(start.GetRequestAddFriends));
                startThread.IsBackground = true;
                startThread.Start();
            }
            catch { }
        }

        public void LoadFriend()
        {
            try
            {
                MyThreadFriend start = new MyThreadFriend();
                start.KQ = "";
                Acc.UrlFriend = "http://friends.meetme.com/";
                start.account = Acc;
                Thread startThread = new Thread(new ThreadStart(start.GetFriends));
                startThread.IsBackground = true;
                startThread.Start();
            }
            catch { }
        }
        public void counter_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.SetText(this, lblResult, KetQua);
                ThreadHelperClass.LoadRequestAddFriend(this, lvAccount,lstRequestAddFriend );
                ThreadHelperClass.SetTimerFull(this, TimeWaiting, true, 5000);
                
            }
            catch { }
        }
        public void counterfriend_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.SetText(this, lblSoLuong, KetQua);
                ThreadHelperClass.LoadFriend(this, dgvListFriends, lstFd);
            }
            catch { }
        }

        public class MyThread
        {
            public string KQ = "";
            public string Link = "";
            public string Ten = "";
            public Account account = new Account();

            public void GetRequestAddFriends()
            {
                try
                {
                    Threading.GetAutoRequestAddFriends(account,ref Link,ref Ten, ref KQ);
                }
                catch { }
            }
        }
        public class MyThreadFriend
        {
            public string KQ = "";
            public string Link = "";
            public string Ten = "";
            public Account account = new Account();

            public void GetFriends()
            {
                try
                {
                    Threading.GetAutoRequestFriends(account, ref Link, ref Ten, ref KQ);
                }
                catch { }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                StartAutoAddFriend();
            }
            catch { }
        }

        public void StartAutoAddFriend()
        {
            try
            {
                MMGiay = int.Parse(nupPause.Value.ToString()) * 1000;
                currentAddFriend = 0;
                CurrentIndex = 0;
                TimeTotal.Interval = 5000;
                TimeTotal.Enabled = true;
                TimeTotal.Start();
            }
            catch { }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                TimeWaiting.Enabled = false;
                TimeWaiting.Stop();
                StopAll = true;
                lblResult.Text = "Stop.";
            }
            catch { }
        }

        int CurrentIndex = 0;
        //int iRequest = 0;
        int MMGiay = 0;
        int iKiemTraGan = 0;
        private void TimeWaiting_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.TimerAddFriend.ToString() != string.Empty)
                    nupPause.Value = Settings.Default.TimerAddFriend;
                MMGiay = int.Parse(nupPause.Value.ToString()) * 1000;
                TimeWaiting.Enabled = false;
                TimeWaiting.Stop();
                if (iKiemTraGan == 0)
                {
                    CurrentIndex = lvAccount.Items.Count - 1;
                    iKiemTraGan = 1;
                }
                lblResult.Text = "";
                if (StopAll)
                {
                    lblResult.Text = "Stop.";
                    return;
                }
                if (CurrentIndex < 0)
                {
                    lblResult.Text = "Finish.";
                    TimeTotal.Interval = MMGiay;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }
                string IdFriend = "";
                string Link = lvAccount.Items[CurrentIndex].Tag.ToString();
                string Name = lvAccount.Items[CurrentIndex].Name.ToString();
                string[] IdTemp = Link.Split('/');
                IdFriend = IdTemp[IdTemp.Length - 1].ToString();
                if (Threading.ClickAccept(Acc, IdFriend))
                {
                    int i = dgvListFriends.Rows.Count;
                    dgvListFriends.Rows.Add();
                    Threading.Friend friend = new Threading.Friend();
                    friend.Ten = Name;
                    //dgvListFriends.Rows.RemoveAt(CurrentIndex);
                    lvAccount.Items.RemoveAt(CurrentIndex);
                    AddGridView(i, Name);
                }
                CurrentIndex--;
                if (CurrentIndex <0)
                {
                    lblResult.Text = "Finish.";
                    currentAddFriend = 0;
                    TimeTotal.Interval = MMGiay;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }
                TimeWaiting.Enabled = true;
                TimeWaiting.Start();
            }
            catch
            {
                if (CurrentIndex < 0)
                {
                    TimeTotal.Interval = MMGiay;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }
                CurrentIndex--;
                TimeWaiting.Enabled = true;
                TimeWaiting.Start();
            }
        }
        int currentAddFriend = 0;
        private void TimeTotal_Tick(object sender, EventArgs e)
        {
            try
            {

                TimeTotal.Enabled = false;
                TimeTotal.Stop();
                lstFd = new List<Threading.Friend>();
                lstRequestAddFriend = new List<Threading.Friend>();
                lblResult.Text = "";
                lblSoLuong.Text = "";
                lvAccount.Items.Clear();
                dgvListFriends.Rows.Clear();
                iKiemTraGan = 0;
                if (currentAddFriend >= lstAccount.Count)
                {
                    lblResult.Text = "Finish.";
                    currentAddFriend = 0;
                    TimeTotal.Interval = MMGiay;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }
                Acc = lstAccount[currentAddFriend];
                KetQua = "Loading request, " + Acc.UserName;
                counter.Count++;
                LoadRequestAddFriend();
                LoadFriend();
                currentAddFriend++;
            }
            catch
            {
                if (currentAddFriend >= lstAccount.Count)
                {
                    lblResult.Text = "Finish.";
                    currentAddFriend = 0;
                    TimeTotal.Interval = MMGiay;
                    TimeTotal.Enabled = true;
                    TimeTotal.Start();
                    return;
                }
                currentAddFriend++;
                Acc = lstAccount[currentAddFriend];
                KetQua = "Loading request, " + Acc.UserName;
                counter.Count++;
                LoadRequestAddFriend();
                LoadFriend();
            }
        }

        private void AddGridView(int iCurent, string Name)
        {
            try
            {
                dgvListFriends.Rows[iCurent - 1].Cells[grdColIndex.Name].Value = iCurent;
                dgvListFriends.Rows[iCurent - 1].Cells[grdColAccount.Name].Value = Name;
                dgvListFriends.Rows[iCurent - 1].Cells[grdColStatus.Name].Value = "Susscess";
            }
            catch { }
        }

        public static int StopAllRequest = 0;
        private void frmAutoRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                TimeWaiting.Enabled = false;
                TimeWaiting.Stop();
                TimeTotal.Enabled = false;
                TimeTotal.Stop();
                StopAllRequest = 1;
            }
            catch { }
        }

        
    }
}
