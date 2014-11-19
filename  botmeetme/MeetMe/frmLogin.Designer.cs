namespace MeetMe
{
    partial class frmLogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnRead = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvNick = new System.Windows.Forms.DataGridView();
            this.grdColIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeWaitting = new System.Windows.Forms.Timer(this.components);
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNick)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.btnLogin);
            this.groupPanel2.Controls.Add(this.txtPath);
            this.groupPanel2.Controls.Add(this.btnRead);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(469, 45);
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
            this.groupPanel2.TabIndex = 9;
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
            this.btnLogin.Location = new System.Drawing.Point(411, 9);
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
            this.txtPath.Size = new System.Drawing.Size(280, 20);
            this.txtPath.TabIndex = 14;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // btnRead
            // 
            this.btnRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRead.Location = new System.Drawing.Point(355, 9);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(49, 23);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvNick);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 45);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(469, 351);
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
            this.groupPanel1.TabIndex = 10;
            this.groupPanel1.Text = "List nick";
            // 
            // dgvNick
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNick.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdColIndex,
            this.grdColID,
            this.grdColNick,
            this.grdColPass,
            this.grdColStatus});
            this.dgvNick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNick.Location = new System.Drawing.Point(0, 0);
            this.dgvNick.Name = "dgvNick";
            this.dgvNick.RowHeadersWidth = 4;
            this.dgvNick.Size = new System.Drawing.Size(463, 330);
            this.dgvNick.TabIndex = 0;
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
            // grdColPass
            // 
            this.grdColPass.HeaderText = "Pass";
            this.grdColPass.Name = "grdColPass";
            this.grdColPass.Visible = false;
            // 
            // grdColStatus
            // 
            this.grdColStatus.HeaderText = "Status";
            this.grdColStatus.Name = "grdColStatus";
            // 
            // TimeWaitting
            // 
            this.TimeWaitting.Interval = 1000;
            this.TimeWaitting.Tick += new System.EventHandler(this.TimeWaitting_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 396);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPath;
        private DevComponents.DotNetBar.ButtonX btnRead;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dgvNick;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColStatus;
        private System.Windows.Forms.Timer TimeWaitting;
    }
}

