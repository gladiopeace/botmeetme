namespace MeetMe
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvNick = new System.Windows.Forms.DataGridView();
            this.grdColIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblResult = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnRead = new DevComponents.DotNetBar.ButtonX();
            this.TimeWaitting = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.smiChat = new System.Windows.Forms.ToolStripMenuItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.TimerAddFriend = new System.Windows.Forms.Timer(this.components);
            this.btnSetting = new DevComponents.DotNetBar.ButtonItem();
            this.btnRequest = new DevComponents.DotNetBar.ButtonItem();
            this.btnChat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDanhSachHangThanhLy = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNick)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.buttonItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(999, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "Main";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(999, 97);
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSetting});
            this.ribbonBar2.Location = new System.Drawing.Point(109, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(52, 94);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Setting";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRequest,
            this.btnChat});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(106, 94);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 0;
            this.ribbonBar3.Text = "Functions";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(999, 152);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhap,
            this.btnThoat});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(90, 149);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Systems";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "System";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Function";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Icon = ((System.Drawing.Icon)(resources.GetObject("office2007StartButton1.Icon")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.Text = "&File";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "MeetMe.Com";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 26);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(408, 345);
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
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 2;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dgvNick);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(0, 59);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(402, 280);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 11;
            // 
            // dgvNick
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNick.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdColIndex,
            this.grdColID,
            this.grdColNick,
            this.grdColProxy,
            this.grdColPort,
            this.grdColPass,
            this.grdColStatus});
            this.dgvNick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNick.Location = new System.Drawing.Point(0, 0);
            this.dgvNick.Name = "dgvNick";
            this.dgvNick.RowHeadersWidth = 4;
            this.dgvNick.Size = new System.Drawing.Size(396, 274);
            this.dgvNick.TabIndex = 0;
            this.dgvNick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvNick_MouseDown);
            // 
            // grdColIndex
            // 
            this.grdColIndex.HeaderText = "Index";
            this.grdColIndex.Name = "grdColIndex";
            this.grdColIndex.Width = 50;
            // 
            // grdColID
            // 
            this.grdColID.HeaderText = "IdNick";
            this.grdColID.Name = "grdColID";
            this.grdColID.Visible = false;
            // 
            // grdColNick
            // 
            this.grdColNick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdColNick.HeaderText = "Nick";
            this.grdColNick.Name = "grdColNick";
            // 
            // grdColProxy
            // 
            this.grdColProxy.HeaderText = "Proxy";
            this.grdColProxy.Name = "grdColProxy";
            this.grdColProxy.Visible = false;
            // 
            // grdColPort
            // 
            this.grdColPort.HeaderText = "Port";
            this.grdColPort.Name = "grdColPort";
            this.grdColPort.Visible = false;
            // 
            // grdColPass
            // 
            this.grdColPass.HeaderText = "Pass";
            this.grdColPass.Name = "grdColPass";
            this.grdColPass.Visible = false;
            // 
            // grdColStatus
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdColStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdColStatus.HeaderText = "Status";
            this.grdColStatus.Name = "grdColStatus";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lblResult);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.btnLogin);
            this.groupPanel2.Controls.Add(this.txtPath);
            this.groupPanel2.Controls.Add(this.btnRead);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(402, 59);
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
            this.groupPanel2.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(69, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 15);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Result";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(9, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 15);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "File name:";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Location = new System.Drawing.Point(337, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(49, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.Border.Class = "TextBoxBorder";
            this.txtPath.Location = new System.Drawing.Point(69, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(206, 20);
            this.txtPath.TabIndex = 14;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // btnRead
            // 
            this.btnRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRead.Location = new System.Drawing.Point(281, 10);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(49, 23);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // TimeWaitting
            // 
            this.TimeWaitting.Interval = 1000;
            this.TimeWaitting.Tick += new System.EventHandler(this.TimeWaitting_Tick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiRequest,
            this.smiChat});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // smiRequest
            // 
            this.smiRequest.Name = "smiRequest";
            this.smiRequest.Size = new System.Drawing.Size(150, 22);
            this.smiRequest.Text = "Requests";
            this.smiRequest.Click += new System.EventHandler(this.smiRequest_Click);
            // 
            // smiChat
            // 
            this.smiChat.Name = "smiChat";
            this.smiChat.Size = new System.Drawing.Size(150, 22);
            this.smiChat.Text = "Chat";
            this.smiChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.groupPanel1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 154);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(408, 371);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 4;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "List Account";
            // 
            // TimerAddFriend
            // 
            this.TimerAddFriend.Tick += new System.EventHandler(this.TimerAddFriend_Tick);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::MeetMe.Properties.Resources.icon_03_17;
            this.btnSetting.ImagePaddingHorizontal = 8;
            this.btnSetting.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.SubItemsExpandWidth = 14;
            this.btnSetting.Text = "Setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnRequest.Image")));
            this.btnRequest.ImagePaddingHorizontal = 8;
            this.btnRequest.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.SubItemsExpandWidth = 14;
            this.btnRequest.Text = "Requests";
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnChat
            // 
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImagePaddingHorizontal = 8;
            this.btnChat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChat.Name = "btnChat";
            this.btnChat.SubItemsExpandWidth = 14;
            this.btnChat.Text = "Chat";
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImagePaddingHorizontal = 8;
            this.btnDangNhap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SubItemsExpandWidth = 14;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImagePaddingHorizontal = 8;
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 14;
            this.btnThoat.Text = "Exit";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDanhSachHangThanhLy
            // 
            this.btnDanhSachHangThanhLy.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachHangThanhLy.Image")));
            this.btnDanhSachHangThanhLy.ImagePaddingHorizontal = 8;
            this.btnDanhSachHangThanhLy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSachHangThanhLy.Name = "btnDanhSachHangThanhLy";
            this.btnDanhSachHangThanhLy.SubItemsExpandWidth = 14;
            this.btnDanhSachHangThanhLy.Text = "Danh sách thanh lý";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(999, 525);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNick)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnDangNhap;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnRequest;
        private DevComponents.DotNetBar.ButtonItem btnChat;
        private DevComponents.DotNetBar.ButtonItem btnDanhSachHangThanhLy;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPath;
        private DevComponents.DotNetBar.ButtonX btnRead;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.DataGridView dgvNick;
        private System.Windows.Forms.Timer TimeWaitting;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem smiRequest;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.LabelX lblResult;
        private System.Windows.Forms.ToolStripMenuItem smiChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColProxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColStatus;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        //private DevComponents.DotNetBar.ButtonItem btnAutoAddFriend;
        private DevComponents.DotNetBar.ButtonItem btnSetting;
        private System.Windows.Forms.Timer TimerAddFriend;
    }
}