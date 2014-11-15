using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace MeetMe
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public static Account Acc = new Account();
        public static List<Account> lstAcc = new List<Account>();
        public static Threading.MyUser ListUser = new Threading.MyUser();
        private static MeetMe.Threading.Counter counter = new MeetMe.Threading.Counter();
        private static MeetMe.Threading.Counter counterSuccess = new MeetMe.Threading.Counter();
        private static MeetMe.Threading.Counter counterFails = new MeetMe.Threading.Counter();
        public static string KetQua = "";
        public bool FlagLogin = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                counter.OnCounterChanged += new EventHandler(counter_OnCounterChanged);
                //txtPath.Text = "vnsoft05@gmail.com";//thanh1509@gmail.com
                //txtPass.Text = "thanh123456";
                this.Hide();
            }
            catch { }
        }

        public void counter_OnCounterChanged(object sender, EventArgs e)
        {
            try
            {
                ThreadHelperClass.LoadUser(this, dgvNick, ListUser);
            }
            catch{ }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string Link = txtLinkGet.Text;
                //if (Link.IndexOf('/') == -1)
                //    Link = "http://www.meetme.com/member/" + txtLinkGet.Text;
                //Acc.UrlProfile = Link;
                //MyThread start = new MyThread();
                //start.account = Acc;
                //Thread startThread = new Thread(new ThreadStart(start.GetProfile));
                //startThread.IsBackground = true;
                //startThread.Start();
            }
            catch { }
        }
        
        public class MyThread
        {
            string Ten = "";
            string Tuoi = "";
            string GioiTinh = "";
            string TinhTrangHonNhan = "";
            string ThanhPho = "";
            string KhuVuc = "";
            string QuocGia = "";
            public Account account = new Account();
            public void GetProfile()
            {
                KetQua = "Đang quét dữ liệu, xin chờ...";
                counter.Count++;
                Threading.GetProfile(account, ref Ten, ref Tuoi, ref GioiTinh, ref TinhTrangHonNhan, ref ThanhPho, ref KhuVuc, ref QuocGia);
                string KQ = "";
                if (Ten.Trim() != "")
                    KQ = "Tên: " + Ten + "\n";
                if (Tuoi.Trim() != "")
                    KQ += "Tuổi: " + Tuoi + "\n";
                if (GioiTinh.Trim() != "")
                    KQ += "Giới tính: " + GioiTinh + "\n";
                if (TinhTrangHonNhan.Trim() != "")
                    KQ += "Tình trạng hôn nhân: " + TinhTrangHonNhan + "\n";
                if (QuocGia.Trim() != "")
                    KQ += "Địa chỉ: " + ThanhPho + " - " + KhuVuc + " - " + QuocGia;
                KetQua = KQ;
                if (KetQua.Trim() == "")
                    KetQua = "Không lấy được thông tin từ link này.";
                counter.Count++;
            }
        }

        public class ThreadLogin
        {
            public Account Acc;
            public int Current;
            public DataGridView dgv;
            public void Login()
            {
                try
                {
                    Threading.Login(Acc, dgv, Current);
                    //if (Threading.Login(Acc,dgv,Current))
                    //    counterSuccess.Count++;
                    //else
                    //    counterFails.Count++;
                }
                catch { }

            }
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtPath.Text.Trim() == "" || txtPass.Text == "")
                //{
                //    MessageBox.Show("Please, enter the full information.", "Message");
                //    return;
                //}
                //Acc = new Account();
                //Acc.UserName = txtPath.Text;
                //Acc.Password = txtPass.Text;
                //Acc.UrlLogin = "https://ssl.meetme.com/login";

                //if (Threading.Login(Acc))
                //{
                //    Main.Acc = Acc;
                //    FlagLogin = true;
                //    this.Close();
                //}
                //else
                //    MessageBox.Show("Login failed!!!");
            }
            catch { MessageBox.Show("Login failed!!!"); }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    btnLogins_Click(sender, e);
            }
            catch { }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    btnLogins_Click(sender, e);
            }
            catch { }
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sFile = new OpenFileDialog();
                sFile.Filter = "All Files *.*|*.*";
                DialogResult dialogResult = sFile.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    txtPath.Text = sFile.FileName;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNick.Rows.Clear();
                using (var reader = new StreamReader(txtPath.Text))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            string[] user = line.Split('|');
                            ListUser = new Threading.MyUser();
                            ListUser.Id = user[0];
                            ListUser.Name = user[1];
                            ListUser.Pass = user[2];
                            counter.Count++;
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _Curr = 0;
                lstAcc = new List<Account>();
                TimeWaitting.Enabled = true;
                TimeWaitting.Start();
            }
            catch { }
        }
        int _Curr = 0;
        private void TimeWaitting_Tick(object sender, EventArgs e)
        {
            try
            {
                ThreadLogin thLong = new ThreadLogin();
                thLong.Current = _Curr;
                Acc = new Account();
                Acc.UserName = dgvNick.Rows[_Curr].Cells[grdColNick.Name].Value.ToString();
                Acc.Password = dgvNick.Rows[_Curr].Cells[grdColPass.Name].Value.ToString();
                Acc.ID = int.Parse(dgvNick.Rows[_Curr].Cells[grdColID.Name].Value.ToString());
                Acc.UrlLogin = "https://ssl.meetme.com/login";
                thLong.Acc = Acc;
                thLong.dgv = dgvNick;
                Thread start = new Thread(new ThreadStart(thLong.Login));
                start.IsBackground = true;
                start.Start();
                _Curr++;
            }
            catch {
                TimeWaitting.Enabled = false;
                TimeWaitting.Stop(); 
            }
        }      
        
    }
}
