namespace OSproject
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfProcessesDropList = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AlgorithmsList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextMainBtn = new System.Windows.Forms.Button();
            this.BackMainbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcessesDropList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scheduling algorithm";
            // 
            // NumberOfProcessesDropList
            // 
            this.NumberOfProcessesDropList.Location = new System.Drawing.Point(325, 118);
            this.NumberOfProcessesDropList.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumberOfProcessesDropList.Name = "NumberOfProcessesDropList";
            this.NumberOfProcessesDropList.ReadOnly = true;
            this.NumberOfProcessesDropList.Size = new System.Drawing.Size(243, 20);
            this.NumberOfProcessesDropList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processes Scheduling";
            // 
            // AlgorithmsList
            // 
            this.AlgorithmsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmsList.FormattingEnabled = true;
            this.AlgorithmsList.Items.AddRange(new object[] {
            "FCFS",
            "RR",
            "Priority(Pre-emptive)",
            "Priority(Non-Pre-emptive)",
            "SJF(Pre-emptive)",
            "SJF(Non-Pre-emptive)"});
            this.AlgorithmsList.Location = new System.Drawing.Point(325, 182);
            this.AlgorithmsList.Name = "AlgorithmsList";
            this.AlgorithmsList.Size = new System.Drawing.Size(243, 21);
            this.AlgorithmsList.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 15);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 17);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 274);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(940, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 274);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(905, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NextMainBtn
            // 
            this.NextMainBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMainBtn.Location = new System.Drawing.Point(760, 241);
            this.NextMainBtn.Name = "NextMainBtn";
            this.NextMainBtn.Size = new System.Drawing.Size(158, 42);
            this.NextMainBtn.TabIndex = 11;
            this.NextMainBtn.Text = "Next";
            this.NextMainBtn.UseVisualStyleBackColor = false;
            this.NextMainBtn.Click += new System.EventHandler(this.NextMainBtn_Click);
            // 
            // BackMainbtn
            // 
            this.BackMainbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackMainbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMainbtn.Location = new System.Drawing.Point(44, 241);
            this.BackMainbtn.Name = "BackMainbtn";
            this.BackMainbtn.Size = new System.Drawing.Size(158, 42);
            this.BackMainbtn.TabIndex = 11;
            this.BackMainbtn.Text = "Back";
            this.BackMainbtn.UseVisualStyleBackColor = false;
            this.BackMainbtn.Click += new System.EventHandler(this.BackMainbtn_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 306);
            this.Controls.Add(this.BackMainbtn);
            this.Controls.Add(this.NextMainBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AlgorithmsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfProcessesDropList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_menu";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcessesDropList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberOfProcessesDropList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AlgorithmsList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextMainBtn;
        private System.Windows.Forms.Button BackMainbtn;
    }
}