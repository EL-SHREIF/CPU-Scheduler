using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class data_input_p : Form
    {
        NumericUpDown[] arrival;
        NumericUpDown[] brust;
        NumericUpDown[] priorit;

        public static int[] cpu_brustTime;
        public static int[] arrivalTime;
        public static int[] priority;

        public data_input_p()
        {
            InitializeComponent();
            arrival = new NumericUpDown[Form_process.no_of_process + 1];
            brust = new NumericUpDown[Form_process.no_of_process + 1];
            priorit = new NumericUpDown[Form_process.no_of_process+1];

            cpu_brustTime = new int[Form_process.no_of_process + 1];
            arrivalTime = new int[Form_process.no_of_process + 1];
            priority = new int[Form_process.no_of_process + 1];

            this.groupBox_processDetail.AutoScroll = true;
            names();
            arrivals();
            brusts();
            pss();
        }
        private void names()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process " + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.groupBox_processDetail.Controls.Add(new_lb);
                y = y + 60;
            }
        }

        private void arrivals()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.num_p1_arrival;
            num_old.Enabled = true;
            int y = 60;
            arrival[0] = this.num_p1_arrival;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "P_ProcessArrivalTime" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                num.ReadOnly = true;
                arrival[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }
        private void brusts()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.num_p1_burst;
            num_old.Enabled = true;
            int y = 60;
            brust[0] = this.num_p1_burst;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.TextAlign = num_old.TextAlign;
                num.Maximum = num_old.Maximum;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "P_ProcessBrust" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                num.ReadOnly = true;
                brust[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }
        private void pss()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.P1;
            num_old.Enabled = true;
            int y = 60;
            priorit[0] = this.P1;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.TextAlign = num_old.TextAlign;
                num.Maximum = num_old.Maximum;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "P_ProcessBrust" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                priorit[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num_p1_arrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void P1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Form_process form2 = new Form_process();
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form_process.no_of_process; i++)
            {
                arrivalTime[i] = (int)arrival[i].Value;
                cpu_brustTime[i] = (int)brust[i].Value;
                priority[i] = (int) priorit[i].Value;
            }
            Results R = new Results();
            R.Show();
            this.Hide();
        }
    }
}
