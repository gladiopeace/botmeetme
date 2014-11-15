using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MeetMe.Properties;
namespace MeetMe
{
    public partial class frmSetting : DevComponents.DotNetBar.Office2007Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.TimerAddFriend.ToString() != string.Empty && Settings.Default.TimerChat.ToString() != string.Empty && Settings.Default.UserOnline.ToString() != string.Empty)
                {
                    intAddFriend.Value = Settings.Default.TimerAddFriend;
                    intChat.Value = Settings.Default.TimerChat;
                    intOnline.Value = Settings.Default.UserOnline;
                    if (Settings.Default.FileChat.ToString() != string.Empty)
                        txtPath.Text = Settings.Default.FileChat;
                }
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Trim() == "")
                {
                    MessageBox.Show("Please select file chat.", "Message");
                    return;
                }
                if (intChat.Value != 0 && intAddFriend.Value != 0 && intOnline.Value != 0)
                {
                    Settings.Default.TimerAddFriend = intAddFriend.Value;
                    Settings.Default.TimerChat = intChat.Value;
                    Settings.Default.UserOnline = intOnline.Value;
                    Settings.Default.FileChat = txtPath.Text.Trim();
                    Settings.Default.Save();
                    MessageBox.Show("Update success.", "Message");
                }
                else
                    MessageBox.Show("Update failure.");
            }
            catch { MessageBox.Show("Update failure."); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }

        private void intAddFriend_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (intAddFriend.Value == 0 || intAddFriend.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Invalid value", "Error");
                    intAddFriend.Value = 1;
                }
            }
            catch { intAddFriend.Value = 1; }
        }

        private void intChat_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (intChat.Value == 0 || intChat.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Invalid value", "Error");
                    intChat.Value = 1;
                }
            }
            catch { intChat.Value = 1; }
        }

        private void intOnline_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (intOnline.Value == 0 || intOnline.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Invalid value", "Error");
                    intOnline.Value = 1;
                }
                else
                    lblNick.Text = intOnline.Value + " User";
            }
            catch { intOnline.Value = 1; }

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
