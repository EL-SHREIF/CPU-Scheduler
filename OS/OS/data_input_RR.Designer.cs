namespace OS
{
    partial class data_input_RR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_input_RR));
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox_processDetail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.num_p1_arrival = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantum = new System.Windows.Forms.Label();
            this.numericUpDown_QuantumTime = new System.Windows.Forms.NumericUpDown();
            this.num_p1_burst = new System.Windows.Forms.NumericUpDown();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.lbl_burst_l = new System.Windows.Forms.Label();
            this.lbl_arrival_l = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_processDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_arrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QuantumTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_burst)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_back.Location = new System.Drawing.Point(46, 442);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 38);
            this.btn_back.TabIndex = 45;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox_processDetail
            // 
            this.groupBox_processDetail.AutoScroll = true;
            this.groupBox_processDetail.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.groupBox_processDetail.BackColor = System.Drawing.Color.White;
            this.groupBox_processDetail.Controls.Add(this.label1);
            this.groupBox_processDetail.Controls.Add(this.label21);
            this.groupBox_processDetail.Controls.Add(this.num_p1_arrival);
            this.groupBox_processDetail.Controls.Add(this.lbl_quantum);
            this.groupBox_processDetail.Controls.Add(this.numericUpDown_QuantumTime);
            this.groupBox_processDetail.Controls.Add(this.num_p1_burst);
            this.groupBox_processDetail.Controls.Add(this.lbl_p1);
            this.groupBox_processDetail.Controls.Add(this.lbl_burst_l);
            this.groupBox_processDetail.Controls.Add(this.lbl_arrival_l);
            this.groupBox_processDetail.Location = new System.Drawing.Point(46, 30);
            this.groupBox_processDetail.Name = "groupBox_processDetail";
            this.groupBox_processDetail.Size = new System.Drawing.Size(666, 391);
            this.groupBox_processDetail.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Processes Details";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(477, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 21);
            this.label21.TabIndex = 50;
            this.label21.Text = "ms";
            // 
            // num_p1_arrival
            // 
            this.num_p1_arrival.BackColor = System.Drawing.Color.Bisque;
            this.num_p1_arrival.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_p1_arrival.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_p1_arrival.Location = new System.Drawing.Point(119, 90);
            this.num_p1_arrival.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_p1_arrival.Name = "num_p1_arrival";
            this.num_p1_arrival.ReadOnly = true;
            this.num_p1_arrival.Size = new System.Drawing.Size(61, 35);
            this.num_p1_arrival.TabIndex = 51;
            this.num_p1_arrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_quantum
            // 
            this.lbl_quantum.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_quantum.ForeColor = System.Drawing.Color.Gray;
            this.lbl_quantum.Location = new System.Drawing.Point(408, 59);
            this.lbl_quantum.Name = "lbl_quantum";
            this.lbl_quantum.Size = new System.Drawing.Size(189, 39);
            this.lbl_quantum.TabIndex = 29;
            this.lbl_quantum.Text = "Quantum time :";
            // 
            // numericUpDown_QuantumTime
            // 
            this.numericUpDown_QuantumTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown_QuantumTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_QuantumTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_QuantumTime.Location = new System.Drawing.Point(446, 119);
            this.numericUpDown_QuantumTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_QuantumTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_QuantumTime.Name = "numericUpDown_QuantumTime";
            this.numericUpDown_QuantumTime.ReadOnly = true;
            this.numericUpDown_QuantumTime.Size = new System.Drawing.Size(104, 29);
            this.numericUpDown_QuantumTime.TabIndex = 28;
            this.numericUpDown_QuantumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_QuantumTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_p1_burst
            // 
            this.num_p1_burst.BackColor = System.Drawing.Color.Bisque;
            this.num_p1_burst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_p1_burst.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_p1_burst.Location = new System.Drawing.Point(253, 90);
            this.num_p1_burst.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_p1_burst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p1_burst.Name = "num_p1_burst";
            this.num_p1_burst.ReadOnly = true;
            this.num_p1_burst.Size = new System.Drawing.Size(60, 35);
            this.num_p1_burst.TabIndex = 7;
            this.num_p1_burst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_p1_burst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p1_burst.ValueChanged += new System.EventHandler(this.num_p1_burst_ValueChanged);
            // 
            // lbl_p1
            // 
            this.lbl_p1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_p1.Location = new System.Drawing.Point(17, 102);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(82, 17);
            this.lbl_p1.TabIndex = 43;
            this.lbl_p1.Text = "Process 1";
            // 
            // lbl_burst_l
            // 
            this.lbl_burst_l.AutoSize = true;
            this.lbl_burst_l.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_burst_l.ForeColor = System.Drawing.Color.Gray;
            this.lbl_burst_l.Location = new System.Drawing.Point(239, 59);
            this.lbl_burst_l.Name = "lbl_burst_l";
            this.lbl_burst_l.Size = new System.Drawing.Size(95, 17);
            this.lbl_burst_l.TabIndex = 12;
            this.lbl_burst_l.Text = "Burst time (ms)";
            // 
            // lbl_arrival_l
            // 
            this.lbl_arrival_l.AutoSize = true;
            this.lbl_arrival_l.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrival_l.ForeColor = System.Drawing.Color.Gray;
            this.lbl_arrival_l.Location = new System.Drawing.Point(99, 59);
            this.lbl_arrival_l.Name = "lbl_arrival_l";
            this.lbl_arrival_l.Size = new System.Drawing.Size(103, 17);
            this.lbl_arrival_l.TabIndex = 24;
            this.lbl_arrival_l.Text = "Arrival time (ms)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(627, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 44;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // data_input_RR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 504);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox_processDetail);
            this.Controls.Add(this.button2);
            this.Name = "data_input_RR";
            this.Text = "data_input";
            this.groupBox_processDetail.ResumeLayout(false);
            this.groupBox_processDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_arrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QuantumTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_p1_burst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel groupBox_processDetail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_quantum;
        private System.Windows.Forms.NumericUpDown numericUpDown_QuantumTime;
        private System.Windows.Forms.NumericUpDown num_p1_arrival;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label lbl_arrival_l;
        private System.Windows.Forms.Label lbl_burst_l;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_p1_burst;
    }
}