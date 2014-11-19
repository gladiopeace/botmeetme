using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using MeetMe.Properties;

namespace MeetMe
{
    public partial class Main : Form
    {
        public static Account Acc = new Account();
        public static List<Account> lstAcc = new List<Account>();
        public static Threading.MyUser ListUser = new Threading.MyUser();
        private static MeetMe.Threading.Counter counter = new MeetMe.Threading.Counter();
        public static MeetMe.Threading.Counter counterLogin = new MeetMe.Threading.Counter();
        private static MeetMe.Threading.Counter counterFails = new MeetMe.Threading.Counter();
        public static string KetQua = "";
        public bool FlagLogin = false;

        public Main()
        {
            InitializeComponent();
        }

        private bool CheckLogin()
        {
            try
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                return frm.FlagLogin;
            }
            catch { return false; }
        }

        private bool CheckTab(string name)
        {
            try
            {
                foreach (var a in MdiChildren)
                {
                    if (a.Name == name)
                    {
                        a.Activate();
                        return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }
        const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        const int SET_FEATURE_ON_PROCESS = 0x00000002;
        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(
            int FeatureEntry,
            [MarshalAs(UnmanagedType.U4)] int dwFlags,
            bool fEnable);

        static void DisableClickSounds()
        {
            CoInternetSetFeatureEnabled(
                FEATURE_DISABLE_NAVIGATION_SOUNDS,
                SET_FEATURE_ON_PROCESS,
                true);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            counter.OnCounterChanged += new EventHandler(counter_OnCounterChanged);
            counterLogin.OnCounterChanged += new EventHandler(counter_OnCounterLoginChanged);
            DisableClickSounds();

            //this.Hide();
            //if (CheckLogin())
            //{
            //    this.Show();
            //}
            //else
            //    this.Close();
        }

        public void counter_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.LoadUser(this, dgvNick, ListUser);
            }
            catch { }
        }

        public void counter_OnCounterLoginChanged(object sender, EventArgs e)
        {
            try
            {
                if ((counterLogin.Count == iUserOnline && iUserOnline != 0) || counterLogin.Count >= dgvNick.Rows.Count - 1)
                {
                    ThreadHelperClass.SetText(this, lblResult, "Completion");
                    ThreadHelperClass.SetButton(this, btnLogin, "Login");
                    ThreadHelperClass.RemoveGrid(this, dgvNick, iUserOnline - 1, "OK");
                    //WriteFile();
                    ThreadHelperClass.SetTimerFull(this, TimerAddFriend, true, 2000);
                }
            }
            catch { }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frm = new frmLogin();
                if (!CheckTab(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch { }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int Current = dgvNick.CurrentRow.Index;
                string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                if (acc != null)
                {
                    frmRequest frm = new frmRequest(acc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        public void WriteFile()
        {
            try
            {
                //for (int i = 0; i < dgvNick.Rows.Count - 1; i++) 
                //{
                //    dgvNick.Rows[i].Cells[grdColStatus.Name].Value = "Failed";
                //    dgvNick.Rows.RemoveAt(i);

                //}

                string strTemp = Application.StartupPath + "\\" + "Temp.txt";
                string strFile = Application.StartupPath + "\\" + "User.txt";
                //StreamWriter ReFile = new StreamWriter(strFile, true);
                //var linesToKeep = File.ReadLines(txtPath.Text.Trim()).ToList();
                lstAcc = (from l in lstAcc where l.Login == true select l).ToList();
                using (var sr = new StreamReader(strTemp))
                using (var sw = new StreamWriter(strFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (Account acc in lstAcc)
                        {
                            if (line.IndexOf(acc.UserName) >= 0 && line.IndexOf(acc.Password) >= 0)
                                sw.WriteLine(line);
                        }

                    }
                }

            }
            catch { }
        }

        int iSoLuongNick = 0;
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Trim() != "")
                {
                    //copy
                    string pathCopy = Application.StartupPath + "\\" + "Temp.txt";
                    File.Copy(txtPath.Text.Trim(), pathCopy, true);

                    dgvNick.Rows.Clear();
                    lstAcc = new List<Account>();
                    iSoLuongNick = 0;
                    using (var reader = new StreamReader(txtPath.Text))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            try
                            {
                                string[] user = line.Split(':');
                                ListUser = new Threading.MyUser();
                                ListUser.Name = user[0];
                                ListUser.Pass = user[1];
                                ListUser.Proxy = user[2];
                                ListUser.Port = user[3];
                                iSoLuongNick++;
                                counter.Count++;
                            }
                            catch { }
                        }
                    }
                    lblResult.Text = iSoLuongNick.ToString() + " Nick.";
                }
                else
                {
                    MessageBox.Show("Please select file account.", "Message.");
                }
            }
            catch { }
        }

        int iUserOnline = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnLogin.Text == "Login")
                {
                    iUserOnline = 0;
                    _Curr = 0;
                    Main.counterLogin.Count = 0;
                    if (Settings.Default.UserOnline.ToString() != string.Empty)
                        iUserOnline = Settings.Default.UserOnline;
                    else
                    {
                        MessageBox.Show("Please enter your account number.", "Message");
                        frmSetting frm = new frmSetting();
                        frm.ShowDialog();
                        if (Settings.Default.UserOnline.ToString() != string.Empty)
                            iUserOnline = Settings.Default.UserOnline;
                    }
                    btnLogin.Text = "Pause";
                    lblResult.Text = "Login, Please waitting...";
                    lstAcc = new List<Account>();
                    TimeWaitting.Enabled = true;
                    TimeWaitting.Start();
                }
                else
                {
                    //Main.counterLogin.Count = 0;
                    btnLogin.Text = "Login";
                    lblResult.Text = "Pause.";
                    lstAcc = new List<Account>();
                    TimeWaitting.Enabled = false;
                    TimeWaitting.Stop();
                }
            }
            catch { }
        }

        int _Curr = 0;
        private void TimeWaitting_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_Curr >= iUserOnline)
                {
                    TimeWaitting.Enabled = false;
                    TimeWaitting.Stop();
                    return;
                }
                ThreadLogin thLong = new ThreadLogin();
                thLong.Current = _Curr;
                Acc = new Account();
                Acc.UserName = dgvNick.Rows[_Curr].Cells[grdColNick.Name].Value.ToString();
                Acc.Password = dgvNick.Rows[_Curr].Cells[grdColPass.Name].Value.ToString();
                Acc.Proxy = dgvNick.Rows[_Curr].Cells[grdColProxy.Name].Value.ToString();
                Acc.Port = dgvNick.Rows[_Curr].Cells[grdColPort.Name].Value.ToString();
                //Acc.ID = int.Parse(dgvNick.Rows[_Curr].Cells[grdColID.Name].Value.ToString());
                Acc.UrlLogin = "https://ssl.meetme.com/login";
                dgvNick.Rows[_Curr].Cells[grdColStatus.Name].Value = "Waitting...";
                thLong.Acc = Acc;
                thLong.dgv = dgvNick;
                thLong.file = txtPath.Text.Trim();
                Thread start = new Thread(new ThreadStart(thLong.Login));
                start.IsBackground = true;
                start.Start();
                _Curr++;
            }
            catch
            {
                TimeWaitting.Enabled = false;
                TimeWaitting.Stop();
            }
        }
        public class ThreadLogin
        {
            public Account Acc;
            public int Current;
            public DataGridView dgv;
            public string file = "";
            public void Login()
            {
                try
                {
                    Threading.Login(Acc, dgv, Current);
                }
                catch { }

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

        private void dgvNick_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cmsMenu.Show(this.dgvNick, e.X, e.Y);
                }
            }
            catch { }
        }

        private void smiAutoRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAcc.Count > 0)
                {
                    frmAutoRequest frm = new frmAutoRequest(lstAcc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            try
            {
                int Current = dgvNick.CurrentRow.Index;
                string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                if (acc != null)
                {
                    frmChat frm = new frmChat(acc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void smiAutoRequset_Click(object sender, EventArgs e)
        {
            try
            {
                int Current = dgvNick.CurrentRow.Index;
                string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                if (acc != null)
                {
                    frmChat frm = new frmChat(acc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void smiAutoChat_Click(object sender, EventArgs e)
        {
            try
            {
                //int Current = dgvNick.CurrentRow.Index;
                //string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                //Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                //if (acc != null)
                //{
                if (lstAcc.Count > 0)
                {
                    frmAutoChat frm = new frmAutoChat(lstAcc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void smiRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int Current = dgvNick.CurrentRow.Index;
                string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                if (acc != null)
                {
                    frmRequest frm = new frmRequest(acc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetting frm = new frmSetting();
                if (!CheckTab(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch { }
        }

        private void btnAutoAddFriend_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAcc.Count > 0)
                {
                    frmAutoRequest frm = new frmAutoRequest(lstAcc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        private void btnAutoChat_Click(object sender, EventArgs e)
        {
            try
            {
                //int Current = dgvNick.CurrentRow.Index;
                //string Nick = dgvNick.Rows[Current].Cells[grdColNick.Name].Value.ToString();
                //Account acc = (from l in lstAcc where l.UserName.Equals(Nick) select l).FirstOrDefault();
                //if (acc != null)
                //{
                if (lstAcc.Count > 0)
                {
                    frmAutoChat frm = new frmAutoChat(lstAcc);
                    if (!CheckTab(frm.Name))
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("Please press on the button login", "Messages");
            }
            catch { }
        }

        int iTimerLook = 0;
        private void TimerAddFriend_Tick(object sender, EventArgs e)
        {
            try
            {
                frmAutoRequest frm = new frmAutoRequest(lstAcc);
                frmAutoChat frmC = new frmAutoChat(lstAcc);
                CloseTab(frm.Name);
                CloseTab(frmC.Name);

                if (!CheckTab(frmC.Name))
                {
                    //Timer open form
                    TimerAddFriend.Enabled = false;
                    TimerAddFriend.Stop();
                    frmC.MdiParent = this;
                    frmC.Show();
                }

                if (!CheckTab(frm.Name))
                {
                    TimerAddFriend.Enabled = false;
                    TimerAddFriend.Stop();
                    frm.MdiParent = this;
                    frm.Show();
                    //frm.Hide();
                }                
            }
            catch { }
        }

        public void CloseTab(string name)
        {
            try
            {
                foreach (var i in MdiChildren)
                {
                    if (i.Name == name)
                    {
                        i.Close();
                    }
                }
            }
            catch { }
        }

        public void TimerLook_Tick(object sender, EventArgs e)
        {
            try
            {
                if (iTimerLook == 1)
                {
                    iTimerLook = 0;
                    
                }
            }
            catch { }
        }
    }
}
