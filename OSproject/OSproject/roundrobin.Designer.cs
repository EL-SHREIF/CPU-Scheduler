namespace OSproject
{
    partial class roundrobin
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NumberOfProcessesDropList = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FCFSBackBtn = new System.Windows.Forms.Button();
            this.FCFSSimulateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcessesDropList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.NumberOfProcessesDropList);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.FCFSBackBtn);
            this.splitContainer1.Panel2.Controls.Add(this.FCFSSimulateBtn);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(952, 293);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 0;
            // 
            // NumberOfProcessesDropList
            // 
            this.NumberOfProcessesDropList.Location = new System.Drawing.Point(554, 79);
            this.NumberOfProcessesDropList.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumberOfProcessesDropList.MaximumSize = new System.Drawing.Size(100, 0);
            this.NumberOfProcessesDropList.Name = "NumberOfProcessesDropList";
            this.NumberOfProcessesDropList.ReadOnly = true;
            this.NumberOfProcessesDropList.Size = new System.Drawing.Size(72, 20);
            this.NumberOfProcessesDropList.TabIndex = 3;
            this.NumberOfProcessesDropList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfProcessesDropList.ValueChanged += new System.EventHandler(this.NumberOfProcessesDropList_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Q =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FCFSBackBtn
            // 
            this.FCFSBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FCFSBackBtn.Location = new System.Drawing.Point(517, 210);
            this.FCFSBackBtn.Name = "FCFSBackBtn";
            this.FCFSBackBtn.Size = new System.Drawing.Size(109, 37);
            this.FCFSBackBtn.TabIndex = 0;
            this.FCFSBackBtn.Text = "Back";
            this.FCFSBackBtn.UseVisualStyleBackColor = true;
            this.FCFSBackBtn.Click += new System.EventHandler(this.FCFSBackBtn_Click);
            // 
            // FCFSSimulateBtn
            // 
            this.FCFSSimulateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FCFSSimulateBtn.Location = new System.Drawing.Point(517, 139);
            this.FCFSSimulateBtn.Name = "FCFSSimulateBtn";
            this.FCFSSimulateBtn.Size = new System.Drawing.Size(109, 37);
            this.FCFSSimulateBtn.TabIndex = 0;
            this.FCFSSimulateBtn.Text = "simulate";
            this.FCFSSimulateBtn.UseVisualStyleBackColor = true;
            this.FCFSSimulateBtn.Click += new System.EventHandler(this.FCFSSimulateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(583, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roundrobin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 293);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roundrobin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCFSInfo";
            this.Load += new System.EventHandler(this.RR_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcessesDropList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FCFSSimulateBtn;
        private System.Windows.Forms.Button FCFSBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfProcessesDropList;


    }
}
