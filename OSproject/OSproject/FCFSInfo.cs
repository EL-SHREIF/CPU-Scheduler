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
    public partial class FCFSInfo : Form
    {
       
        public FCFSInfo()
        {
            InitializeComponent();
        }
        

        private void FCFSInfo_Load(object sender, EventArgs e)
        {
            int x1 = 140;
            int y1 = 0;
            int x2 = 0; 
            int y2 = 0;
            for (int i = 0; i < main_menu.MainNumberOfProcesses; i++)
            {
               
                x2=0;
                Label lbProcessName = new Label();
           
                lbProcessName.Size=new Size(100,25);
                lbProcessName.Location = new Point(x1, y1);
                lbProcessName.Text = "P" + (i + 1).ToString();
                splitContainer1.Panel1.Controls.Add(lbProcessName);
                y1 += 30;

                Label arrivalTime = new Label();
                arrivalTime.Size = new Size(80, 25);
                arrivalTime.Location = new Point(x2, y2);
                arrivalTime.Text = "ArrivalTime:";
                splitContainer1.Panel2.Controls.Add(arrivalTime);
                x2 += 40;

                TextBox txtProcess = new TextBox();
                txtProcess.Size = new Size(150, 25);
                txtProcess.Name = "q" + (i + 1).ToString();
                txtProcess.Location = new Point(x2, y2);
                splitContainer1.Panel2.Controls.Add(txtProcess);
                x2 += 80;

                Label burstTime = new Label();
                burstTime.Size = new Size(80, 25);
                burstTime.Location = new Point(x2, y2);
                burstTime.Text = "BurstTime:";
                splitContainer1.Panel2.Controls.Add(burstTime);
                x2 += 40;

                TextBox txtProcess2 = new TextBox();
                txtProcess2.Size = new Size(150, 25);
                txtProcess2.Name = "q" + (i + 1).ToString();
                txtProcess2.Location = new Point(x2, y2);
                splitContainer1.Panel2.Controls.Add(txtProcess);
                x2 += 40;

                y2 += 25;

                
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}


