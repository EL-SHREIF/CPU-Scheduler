namespace OS
{
    partial class Form_process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_process));
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.groupbox_algorithm = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_Priority_N = new System.Windows.Forms.Label();
            this.lbl_Priority_P = new System.Windows.Forms.Label();
            this.lbl_SJF_N = new System.Windows.Forms.Label();
            this.lbl_RR = new System.Windows.Forms.Label();
            this.lbl_SJF_P = new System.Windows.Forms.Label();
            this.lbl_FCFS = new System.Windows.Forms.Label();
            this.groupBox_numberProcess = new System.Windows.Forms.GroupBox();
            this.numeric_numProcess = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupbox_algorithm.SuspendLayout();
            this.groupBox_numberProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Location = new System.Drawing.Point(323, 462);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 42);
            this.btn_back.TabIndex = 49;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ok_number_of_process);
            this.panel1.Controls.Add(this.groupbox_algorithm);
            this.panel1.Controls.Add(this.groupBox_numberProcess);
            this.panel1.Location = new System.Drawing.Point(58, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 427);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(64, 367);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(502, 46);
            this.btn_ok_number_of_process.TabIndex = 5;
            this.btn_ok_number_of_process.Text = "Next";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // groupbox_algorithm
            // 
            this.groupbox_algorithm.Controls.Add(this.radioButton6);
            this.groupbox_algorithm.Controls.Add(this.radioButton5);
            this.groupbox_algorithm.Controls.Add(this.radioButton4);
            this.groupbox_algorithm.Controls.Add(this.radioButton3);
            this.groupbox_algorithm.Controls.Add(this.radioButton2);
            this.groupbox_algorithm.Controls.Add(this.radioButton1);
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_RR);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_FCFS);
            this.groupbox_algorithm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_algorithm.ForeColor = System.Drawing.Color.Gray;
            this.groupbox_algorithm.Location = new System.Drawing.Point(64, 123);
            this.groupbox_algorithm.Name = "groupbox_algorithm";
            this.groupbox_algorithm.Size = new System.Drawing.Size(502, 226);
            this.groupbox_algorithm.TabIndex = 24;
            this.groupbox_algorithm.TabStop = false;
            this.groupbox_algorithm.Text = "Algorithm";
            // 
            // radioButton6
            // 
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton6.Location = new System.Drawing.Point(252, 163);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(244, 34);
            this.radioButton6.TabIndex = 35;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Priority preemptive";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton5.Location = new System.Drawing.Point(252, 100);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(244, 34);
            this.radioButton5.TabIndex = 34;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Priority nonpreemptive";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton4.Location = new System.Drawing.Point(26, 163);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 34);
            this.radioButton4.TabIndex = 33;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "RR";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton3.Location = new System.Drawing.Point(26, 100);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(213, 34);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "SJF preemptive";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton2.Location = new System.Drawing.Point(252, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(213, 34);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SJF nonpreemptive";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton1.Location = new System.Drawing.Point(26, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 34);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_Priority_N
            // 
            this.lbl_Priority_N.AutoSize = true;
            this.lbl_Priority_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_N.Location = new System.Drawing.Point(290, 137);
            this.lbl_Priority_N.Name = "lbl_Priority_N";
            this.lbl_Priority_N.Size = new System.Drawing.Size(186, 13);
            this.lbl_Priority_N.TabIndex = 30;
            this.lbl_Priority_N.Text = "Priority Scheduling Nonpreemptive";
            // 
            // lbl_Priority_P
            // 
            this.lbl_Priority_P.AutoSize = true;
            this.lbl_Priority_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_P.Location = new System.Drawing.Point(287, 200);
            this.lbl_Priority_P.Name = "lbl_Priority_P";
            this.lbl_Priority_P.Size = new System.Drawing.Size(163, 13);
            this.lbl_Priority_P.TabIndex = 28;
            this.lbl_Priority_P.Text = "Priority Scheduling Preemptive";
            // 
            // lbl_SJF_N
            // 
            this.lbl_SJF_N.AutoSize = true;
            this.lbl_SJF_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_N.Location = new System.Drawing.Point(287, 79);
            this.lbl_SJF_N.Name = "lbl_SJF_N";
            this.lbl_SJF_N.Size = new System.Drawing.Size(178, 13);
            this.lbl_SJF_N.TabIndex = 26;
            this.lbl_SJF_N.Text = "Shortest Job First Nonpreemptive";
            // 
            // lbl_RR
            // 
            this.lbl_RR.AutoSize = true;
            this.lbl_RR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RR.ForeColor = System.Drawing.Color.Gray;
            this.lbl_RR.Location = new System.Drawing.Point(51, 200);
            this.lbl_RR.Name = "lbl_RR";
            this.lbl_RR.Size = new System.Drawing.Size(76, 13);
            this.lbl_RR.TabIndex = 24;
            this.lbl_RR.Text = "Round Robin";
            // 
            // lbl_SJF_P
            // 
            this.lbl_SJF_P.AutoSize = true;
            this.lbl_SJF_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_P.Location = new System.Drawing.Point(51, 137);
            this.lbl_SJF_P.Name = "lbl_SJF_P";
            this.lbl_SJF_P.Size = new System.Drawing.Size(155, 13);
            this.lbl_SJF_P.TabIndex = 23;
            this.lbl_SJF_P.Text = "Shortest Job First Preemptive";
            // 
            // lbl_FCFS
            // 
            this.lbl_FCFS.AutoSize = true;
            this.lbl_FCFS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FCFS.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FCFS.Location = new System.Drawing.Point(51, 75);
            this.lbl_FCFS.Name = "lbl_FCFS";
            this.lbl_FCFS.Size = new System.Drawing.Size(113, 13);
            this.lbl_FCFS.TabIndex = 22;
            this.lbl_FCFS.Text = "First come First serve";
            // 
            // groupBox_numberProcess
            // 
            this.groupBox_numberProcess.Controls.Add(this.numeric_numProcess);
            this.groupBox_numberProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_numberProcess.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_numberProcess.Location = new System.Drawing.Point(64, 14);
            this.groupBox_numberProcess.Name = "groupBox_numberProcess";
            this.groupBox_numberProcess.Size = new System.Drawing.Size(502, 103);
            this.groupBox_numberProcess.TabIndex = 6;
            this.groupBox_numberProcess.TabStop = false;
            this.groupBox_numberProcess.Text = "Number of process";
            // 
            // numeric_numProcess
            // 
            this.numeric_numProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numeric_numProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_numProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_numProcess.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numeric_numProcess.Location = new System.Drawing.Point(26, 38);
            this.numeric_numProcess.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_numProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.Name = "numeric_numProcess";
            this.numeric_numProcess.ReadOnly = true;
            this.numeric_numProcess.Size = new System.Drawing.Size(450, 46);
            this.numeric_numProcess.TabIndex = 4;
            this.numeric_numProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_numProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.ValueChanged += new System.EventHandler(this.numeric_numProcess_ValueChanged_1);
            // 
            // Form_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 504);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Name = "Form_process";
            this.Text = "choose your algorithm";
            this.Load += new System.EventHandler(this.Form_process_Load);
            this.panel1.ResumeLayout(false);
            this.groupbox_algorithm.ResumeLayout(false);
            this.groupbox_algorithm.PerformLayout();
            this.groupBox_numberProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.GroupBox groupbox_algorithm;
        private System.Windows.Forms.Label lbl_Priority_N;
        private System.Windows.Forms.Label lbl_Priority_P;
        private System.Windows.Forms.Label lbl_SJF_N;
        private System.Windows.Forms.Label lbl_RR;
        private System.Windows.Forms.Label lbl_SJF_P;
        private System.Windows.Forms.Label lbl_FCFS;
        private System.Windows.Forms.GroupBox groupBox_numberProcess;
        private System.Windows.Forms.NumericUpDown numeric_numProcess;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}