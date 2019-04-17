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
    public partial class data_input_RR : Form
    {
        public static int quantum_time;
        NumericUpDown[] arrival;
        NumericUpDown[] brust;

        public static int[] cpu_brustTime;
        public static int[] arrivalTime;
        public static int[] priority;

        public data_input_RR()
        {
            InitializeComponent();
            arrival = new NumericUpDown[Form_process.no_of_process+1];
            brust = new NumericUpDown[Form_process.no_of_process+1];

            cpu_brustTime = new int[Form_process.no_of_process + 1];
            arrivalTime = new int[Form_process.no_of_process + 1];
            priority = new int[Form_process.no_of_process + 1];

            names();
            arrivals();
            brusts();
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
                new_lb.Location = new Point(old_lb.Location.X , old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process " + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible=true;
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
                num.Location = new Point(num_old.Location.X,num_old.Location.Y+y);
                num.Enabled = num_old.Enabled;
                num.Name = "RRProcessArrivalTime" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
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
                num.Maximum = num_old.Maximum;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "RRProcessBrust" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                brust[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_process form2 = new Form_process();
            form2.Show();
            form2.Location = this.Location;
            Hide();  
        }

        private void groupBox_processDetail_Enter(object sender, EventArgs e)
        {

        }

        private void num_p1_burst_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
      
            
            Results R = new Results();
            R.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Form_process.no_of_process; i++)
            {
                arrivalTime[i] = (int)arrival[i].Value;
                cpu_brustTime[i] = (int)brust[i].Value;
                priority[i] = 0;
            }
            quantum_time = (int)this.numericUpDown_QuantumTime.Value;
            Results R = new Results();
            R.Show();
            this.Hide();
        }
    }
}
