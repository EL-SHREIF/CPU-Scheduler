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
    public partial class RR_output : Form
    {
        Panel[] panelArray;
        Panel[] panelExColorProcess;
        Label[] processWaitingTime;
        Label[] processTurnaroundTime;
        Label[] valueGanttChart;
        Label[] label_process;

        roundrobinschedular rr_sch_her;

        static Color colorProcess1 = Color.Red;
        static Color colorProcess2 = Color.Yellow;
        static Color colorProcess3 = Color.Magenta;
        static Color colorProcess4 = Color.Blue;
        static Color colorProcess5 = Color.Lime;
        static Color colorProcess6 = Color.Chocolate;
        static Color colorProcess7 = Color.Aqua;
        static Color colorProcess8 = Color.DarkGreen;
        static Color colorProcess9 = Color.Maroon;
        static Color colorProcess10 = Color.Pink;
        static Color colorFreeTime = Color.Silver;
        static Color color_btn_choose = Color.Silver;
        static Color color_btn_not_choose = Color.WhiteSmoke;


        public RR_output()
        {
            InitializeComponent();
            this.rr_sch_her = roundrobin.rr_sch;
            InitializeComponent();
            rr_sch_her.computeRR();

            
            DrawGanttChart();
     
        }

        public void DrawGanttChart()
        {
            int xPos = 90, yPos = 10;
            tabPage_GanttChart.AutoScroll = true;
            tabPage_GanttChart.VerticalScroll.LargeChange = tabPage_GanttChart.VerticalScroll.Maximum / 2;
            int i = 0;

            while(rr_sch_her.process[i]!=-1)
            {
                Label v = new Label();
                v.Text = "P" +rr_sch_her.process[i] ;
                v.Font = labelEX.Font;
                v.Size = new Size(150, 150);
                v.Location = new Point(xPos - 4, 80);
                v.TextAlign = ContentAlignment.MiddleLeft;
                v.ForeColor = Color.Gray;
                v.BackColor = Color.Transparent;
                v.Visible = true;
                xPos +=20;
                this.Controls.Add(v);
                i++;
            }
        }
    }
}