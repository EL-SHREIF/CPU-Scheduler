using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSproject
{
    public partial class roundrobin : Form
    {
        public roundrobin()
        {
            InitializeComponent();
        }

        private void RR_Load(object sender, EventArgs e)
        {
            MakinglabelNameOfproccess();
            MakinglabelArrivalTime();
            MakinglabelBurstTime();
            FormRR();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MakingLabelFCFS(int xposition,int yposition,int index)
        {
            
           
            Label lbProcessName = new Label();
            lbProcessName.Size = new Size(100, 30);
            lbProcessName.Location = new Point(xposition, yposition);
            lbProcessName.Text = "P" + (index + 1).ToString();
            lbProcessName.BackColor = Color.Azure;
            lbProcessName.TextAlign = ContentAlignment.MiddleCenter;
            lbProcessName.Font = new Font("Arial", 23);
            splitContainer1.Panel1.Controls.Add(lbProcessName);
        }

        private void MakinglabelNameOfproccess()
         {
            Label lbProcessName = new Label();
            lbProcessName.Size = new Size(200, 50);
            lbProcessName.Location = new Point(60,0);
            lbProcessName.Text = "Proccess_Name";
            lbProcessName.BackColor = Color.Azure;
            lbProcessName.TextAlign = ContentAlignment.MiddleCenter;
            lbProcessName.Font = new Font("Arial", 14);
            splitContainer1.Panel1.Controls.Add(lbProcessName);
         }

        private void MakinglabelArrivalTime()
        {
            Label lb= new Label();
            lb.Size = new Size(200, 50);
            lb.Location = new Point(60, 0);
            lb.Text = "ArrivalTime";
            lb.BackColor = Color.Azure;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font("Arial", 14);
            splitContainer1.Panel2.Controls.Add(lb);
        }
        private void MakinglabelBurstTime()
        {
            Label lb = new Label();
            lb.Size = new Size(200, 50);
            lb.Location = new Point(300, 0);
            lb.Text = "BurstTime";
            lb.BackColor = Color.Azure;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font("Arial", 14);
            splitContainer1.Panel2.Controls.Add(lb);
        }

        private void FormRR()
        {
            ProcessesCol();
            arrivalTimeCol();
            BurstTimeCol();
        }
        private void ProcessesCol()
        {
            int y = 60;
            for (int i = 0; i < main_menu.MainNumberOfProcesses; i++)
            {
                Label lbProcessName = new Label();
                lbProcessName.Size = new Size(100, 30);
                lbProcessName.Location = new Point(100, y);
                lbProcessName.Text = "P"+(i+1).ToString();
                lbProcessName.BackColor = Color.Azure;
                lbProcessName.TextAlign = ContentAlignment.MiddleCenter;
                lbProcessName.Font = new Font("Arial", 14);
                splitContainer1.Panel1.Controls.Add(lbProcessName);
                y += 30;

            }
                
        }
        private void arrivalTimeCol()
        {
            int y = 60;
            for (int i = 0; i < main_menu.MainNumberOfProcesses; i++)
            {

                NumericUpDown num = new NumericUpDown();
                num.Size = new Size(200, 25);
                num.Location = new Point(60, y);
                num.ReadOnly = true;
                num.Name = "RRProcessArrivalTime" + (i + 1).ToString();
                num.BackColor = Color.Azure;
                num.Font = new Font("Arial", 14);
                splitContainer1.Panel2.Controls.Add(num);
                y += 30;
            }
        }
        private void BurstTimeCol()
        {
            int y = 60;
            for (int i = 0; i < main_menu.MainNumberOfProcesses; i++)
            {

                NumericUpDown num = new NumericUpDown();
                num.Size = new Size(200, 25);
                num.Location = new Point(300, y);
                num.ReadOnly = true;
                num.Name = "RRProcessBurstTime" + (i + 1).ToString();
                num.BackColor = Color.Azure;
                num.Font = new Font("Arial", 14);
                num.Minimum = 1;
                splitContainer1.Panel2.Controls.Add(num);
                y += 30;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FCFSBackBtn_Click(object sender, EventArgs e)
        {
            main_menu main = new main_menu();
            main.Show();
            this.Hide();
        }
    }
}
