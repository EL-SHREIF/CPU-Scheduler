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
    public partial class Form_process : Form
    {
        public static int no_of_process;
        public static bool MainFCFSflag;
        public static bool RRflag;
        public static bool SJF_premptive;
        public static bool SJF_non_premptive;
        public static bool P_premptive;
        public static bool P_non_premptive;

        public Form_process()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            form.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();
        }

        private void checkBox_SJF_P_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_FCFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_SJF_N_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_process_Load(object sender, EventArgs e)
        {

        }

        private void numeric_numProcess_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            no_of_process = (int)numeric_numProcess.Value;
            MainFCFSflag =(bool)radioButton1.Checked;
            RRflag = (bool)radioButton4.Checked;
            SJF_premptive=(bool)radioButton3.Checked;
            SJF_non_premptive=(bool)radioButton2.Checked;
            P_premptive=(bool)radioButton6.Checked;
            P_non_premptive = (bool)radioButton5.Checked;

            if (RRflag) {
                data_input_RR RR_data = new data_input_RR();
                RR_data.Show();
                RR_data.Location = this.Location;
                //form2.StartPosition = this.StartPosition;
                Hide();
            }
            else if (SJF_non_premptive || SJF_premptive || MainFCFSflag)
            {
                data_input_sjf_fcfs data = new data_input_sjf_fcfs();
                data.Show();
                data.Location = this.Location;
                //form2.StartPosition = this.StartPosition;
                Hide();
            }
            else if (P_non_premptive || P_premptive)
            {
                data_input_p data_p = new data_input_p();
                data_p.Show();
                data_p.Location = this.Location;
                //form2.StartPosition = this.StartPosition;
                Hide();
            }

        }

        private void numeric_numProcess_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
