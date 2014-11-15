namespace MeetMe
{
    partial class frmAutoChat
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
            this.components = new System.ComponentModel.Container();
            this.wbMessages = new System.Windows.Forms.WebBrowser();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblChat = new DevComponents.DotNetBar.LabelX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.lblResult = new DevComponents.DotNetBar.LabelX();
            this.wbListFriendChat = new System.Windows.Forms.WebBrowser();
            this.lvFriendChat = new System.Windows.Forms.ListView();
            this.Col_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeWaitting = new System.Windows.Forms.Timer(this.components);
            this.TimeTotal = new System.Windows.Forms.Timer(this.components);
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbMessages
            // 
            this.wbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMessages.Location = new System.Drawing.Point(0, 0);
            this.wbMessages.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessages.Name = "wbMessages";
            this.wbMessages.ScriptErrorsSuppressed = true;
            this.wbMessages.ScrollBarsEnabled = false;
            this.wbMessages.Size = new System.Drawing.Size(320, 490);
            this.wbMessages.TabIndex = 101;
            this.wbMessages.Visible = false;
            this.wbMessages.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMessages_DocumentCompleted);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnRefresh);
            this.groupPanel2.Controls.Add(this.wbMessages);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel2.Location = new System.Drawing.Point(518, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(320, 421);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "Contents";
            this.groupPanel2.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Location = new System.Drawing.Point(239, 377);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtPath);
            this.groupPanel1.Controls.Add(this.lblChat);
            this.groupPanel1.Controls.Add(this.btnStart);
            this.groupPanel1.Controls.Add(this.lblResult);
            this.groupPanel1.Controls.Add(this.wbListFriendChat);
            this.groupPanel1.Controls.Add(this.lvFriendChat);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(518, 421);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "List messages";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtPath.Border.Class = "TextBoxBorder";
            this.txtPath.Location = new System.Drawing.Point(57, 377);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(194, 20);
            this.txtPath.TabIndex = 106;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // lblChat
            // 
            this.lblChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.Color.Transparent;
            this.lblChat.Location = new System.Drawing.Point(8, 379);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(47, 15);
            this.lblChat.TabIndex = 105;
            this.lblChat.Text = "File chat:";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(257, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(49, 23);
            this.btnStart.TabIndex = 103;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(312, 379);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 15);
            this.lblResult.TabIndex = 101;
            this.lblResult.Text = "Result";
            // 
            // wbListFriendChat
            // 
            this.wbListFriendChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbListFriendChat.Location = new System.Drawing.Point(3, 81);
            this.wbListFriendChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbListFriendChat.Name = "wbListFriendChat";
            this.wbListFriendChat.ScriptErrorsSuppressed = true;
            this.wbListFriendChat.Size = new System.Drawing.Size(506, 286);
            this.wbListFriendChat.TabIndex = 100;
            this.wbListFriendChat.Visible = false;
            this.wbListFriendChat.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbListFriendChat_DocumentCompleted);
            // 
            // lvFriendChat
            // 
            this.lvFriendChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFriendChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Index,
            this.colName,
            this.colMessages,
            this.colTime});
            this.lvFriendChat.FullRowSelect = true;
            this.lvFriendChat.GridLines = true;
            this.lvFriendChat.Location = new System.Drawing.Point(3, 3);
            this.lvFriendChat.Name = "lvFriendChat";
            this.lvFriendChat.Size = new System.Drawing.Size(506, 364);
            this.lvFriendChat.TabIndex = 4;
            this.lvFriendChat.UseCompatibleStateImageBehavior = false;
            this.lvFriendChat.View = System.Windows.Forms.View.Details;
            this.lvFriendChat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAccount_MouseDoubleClick);
            // 
            // Col_Index
            // 
            this.Col_Index.Text = "Index";
            this.Col_Index.Width = 47;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 107;
            // 
            // colMessages
            // 
            this.colMessages.Text = "Messages";
            this.colMessages.Width = 259;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            // 
            // TimeWaitting
            // 
            this.TimeWaitting.Interval = 1000;
            this.TimeWaitting.Tick += new System.EventHandler(this.TimeWaitting_Tick);
            // 
            // TimeTotal
            // 
            this.TimeTotal.Tick += new System.EventHandler(this.TimeTotal_Tick);
            // 
            // frmAutoChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 421);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.DoubleBuffered = true;
            this.Name = "frmAutoChat";
            this.Text = "Auto Chat";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.WebBrowser wbMessages;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.WebBrowser wbListFriendChat;
        private System.Windows.Forms.ListView lvFriendChat;
        private System.Windows.Forms.ColumnHeader Col_Index;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colMessages;
        private System.Windows.Forms.ColumnHeader colTime;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevComponents.DotNetBar.LabelX lblResult;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private System.Windows.Forms.Timer TimeWaitting;
        private System.Windows.Forms.Timer TimeTotal;
        private DevComponents.DotNetBar.LabelX lblChat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPath;
    }
}