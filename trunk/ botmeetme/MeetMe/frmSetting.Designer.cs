namespace MeetMe
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.intAddFriend = new DevComponents.Editors.IntegerInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.intChat = new DevComponents.Editors.IntegerInput();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblNick = new DevComponents.DotNetBar.LabelX();
            this.intOnline = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblChat = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.intAddFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOnline)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(21, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Time add friend: ";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(106, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // intAddFriend
            // 
            // 
            // 
            // 
            this.intAddFriend.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intAddFriend.Location = new System.Drawing.Point(106, 37);
            this.intAddFriend.MinValue = 1;
            this.intAddFriend.Name = "intAddFriend";
            this.intAddFriend.ShowUpDown = true;
            this.intAddFriend.Size = new System.Drawing.Size(124, 20);
            this.intAddFriend.TabIndex = 3;
            this.intAddFriend.Value = 1;
            this.intAddFriend.ValueChanged += new System.EventHandler(this.intAddFriend_ValueChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(49, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 15);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Time chat: ";
            // 
            // intChat
            // 
            // 
            // 
            // 
            this.intChat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intChat.Location = new System.Drawing.Point(106, 61);
            this.intChat.MinValue = 1;
            this.intChat.Name = "intChat";
            this.intChat.ShowUpDown = true;
            this.intChat.Size = new System.Drawing.Size(124, 20);
            this.intChat.TabIndex = 5;
            this.intChat.Value = 1;
            this.intChat.ValueChanged += new System.EventHandler(this.intChat_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(171, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(236, 40);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 15);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Second";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(236, 66);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 15);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Second";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.BackColor = System.Drawing.Color.Transparent;
            this.lblNick.Location = new System.Drawing.Point(236, 92);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(26, 15);
            this.lblNick.TabIndex = 11;
            this.lblNick.Text = "User";
            // 
            // intOnline
            // 
            // 
            // 
            // 
            this.intOnline.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intOnline.Location = new System.Drawing.Point(106, 87);
            this.intOnline.MinValue = 1;
            this.intOnline.Name = "intOnline";
            this.intOnline.ShowUpDown = true;
            this.intOnline.Size = new System.Drawing.Size(124, 20);
            this.intOnline.TabIndex = 10;
            this.intOnline.Value = 1;
            this.intOnline.ValueChanged += new System.EventHandler(this.intOnline_ValueChanged);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(44, 92);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(67, 15);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "User online: ";
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.Border.Class = "TextBoxBorder";
            this.txtPath.Location = new System.Drawing.Point(106, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(170, 20);
            this.txtPath.TabIndex = 108;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.Color.Transparent;
            this.lblChat.Location = new System.Drawing.Point(57, 14);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(47, 15);
            this.lblChat.TabIndex = 107;
            this.lblChat.Text = "File chat:";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(293, 150);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.intOnline);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.intChat);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.intAddFriend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intAddFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOnline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.Editors.IntegerInput intAddFriend;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput intChat;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblNick;
        private DevComponents.Editors.IntegerInput intOnline;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPath;
        private DevComponents.DotNetBar.LabelX lblChat;
    }
}