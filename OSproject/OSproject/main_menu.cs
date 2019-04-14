﻿using System;
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
    public partial class main_menu : Form
    {
        public static int MainNumberOfProcesses;
        public static bool MainFCFSflag;
        public main_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackMainbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void NextMainBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = AlgorithmsList.SelectedItem.ToString();
                MainNumberOfProcesses =(int)NumberOfProcessesDropList.Value;
                if (MainNumberOfProcesses == 0) MessageBox.Show("please min number of processes is 1 process");
                else
                {
                    if (selected == "FCFS")
                    { 
                        MainFCFSflag =true;
                        FCFSInfo fcfs = new FCFSInfo();
                        fcfs.Show();
                 
                        this.Hide();
                    }
                }
                //MessageBox.Show(selected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("please fill data");
            }
        }
    }
}