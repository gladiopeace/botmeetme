namespace MeetMe
{
    partial class frmAutoRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new DevComponents.DotNetBar.LabelX();
            this.lblSoLuong = new DevComponents.DotNetBar.LabelX();
            this.nupPause = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAccount = new System.Windows.Forms.ListView();
            this.Col_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListFriends = new System.Windows.Forms.DataGridView();
            this.grdColIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeWaiting = new System.Windows.Forms.Timer(this.components);
            this.TimeTotal = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPause)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.nupPause);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvAccount);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List requests";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(80, 15);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 15);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "Result";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(385, 163);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(34, 15);
            this.lblSoLuong.TabIndex = 18;
            this.lblSoLuong.Text = "Result";
            // 
            // nupPause
            // 
            this.nupPause.Location = new System.Drawing.Point(222, 53);
            this.nupPause.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPause.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPause.Name = "nupPause";
            this.nupPause.Size = new System.Drawing.Size(72, 20);
            this.nupPause.TabIndex = 8;
            this.nupPause.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pause (second):";
            // 
            // lvAccount
            // 
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Index,
            this.colTen});
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.GridLines = true;
            this.lvAccount.Location = new System.Drawing.Point(27, 32);
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(185, 150);
            this.lvAccount.TabIndex = 4;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            // 
            // Col_Index
            // 
            this.Col_Index.Text = "Index";
            this.Col_Index.Width = 45;
            // 
            // colTen
            // 
            this.colTen.Text = "Name";
            this.colTen.Width = 135;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(218, 159);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(219, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListFriends);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List friends";
            // 
            // dgvListFriends
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFriends.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdColIndex,
            this.grdColAccount,
            this.grdColProxy,
            this.grdColStatus});
            this.dgvListFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListFriends.Location = new System.Drawing.Point(3, 16);
            this.dgvListFriends.Name = "dgvListFriends";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFriends.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListFriends.RowHeadersWidth = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListFriends.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListFriends.Size = new System.Drawing.Size(441, 207);
            this.dgvListFriends.TabIndex = 0;
            // 
            // grdColIndex
            // 
            this.grdColIndex.HeaderText = "Index";
            this.grdColIndex.Name = "grdColIndex";
            this.grdColIndex.Width = 50;
            // 
            // grdColAccount
            // 
            this.grdColAccount.HeaderText = "Account";
            this.grdColAccount.Name = "grdColAccount";
            this.grdColAccount.Width = 250;
            // 
            // grdColProxy
            // 
            this.grdColProxy.HeaderText = "Proxy";
            this.grdColProxy.Name = "grdColProxy";
            this.grdColProxy.Visible = false;
            // 
            // grdColStatus
            // 
            this.grdColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdColStatus.HeaderText = "Status";
            this.grdColStatus.Name = "grdColStatus";
            // 
            // TimeWaiting
            // 
            this.TimeWaiting.Tick += new System.EventHandler(this.TimeWaiting_Tick);
            // 
            // TimeTotal
            // 
            this.TimeTotal.Interval = 1000;
            this.TimeTotal.Tick += new System.EventHandler(this.TimeTotal_Tick);
            // 
            // frmAutoRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmAutoRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto request add friends";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutoRequest_FormClosing);
            this.Load += new System.EventHandler(this.frmRequests_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPause)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFriends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListFriends;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColProxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColStatus;
        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader Col_Index;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.Timer TimeWaiting;
        private System.Windows.Forms.NumericUpDown nupPause;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.LabelX lblSoLuong;
        private DevComponents.DotNetBar.LabelX lblResult;
        private System.Windows.Forms.Timer TimeTotal;
    }
}