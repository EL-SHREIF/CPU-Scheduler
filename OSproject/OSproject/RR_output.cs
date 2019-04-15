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
            rr_sch_her = main_menu.rr_sch;
        }
        public void DrawGanttChart()
        {
            int xPos = 9, yPos = 10;
            tabPage_GanttChart.AutoScroll = true;
            tabPage_GanttChart.VerticalScroll.LargeChange = tabPage_GanttChart.VerticalScroll.Maximum / 2;
            for (int i = 0; i < rr_sch_her.number_ganttChart; i++)
            {
                panelArray[i] = new Panel();
                panelArray[i].Width = 20;
                panelArray[i].Height = 20;
                panelArray[i].Location = new Point(xPos, yPos);

                valueGanttChart[i] = new Label();
                valueGanttChart[i].Text = "" + i;
                valueGanttChart[i].Font = labelEX.Font;
                valueGanttChart[i].Size = new Size(20, 10);
                valueGanttChart[i].Location = new Point(xPos - 4, 40);
                valueGanttChart[i].TextAlign = ContentAlignment.MiddleLeft;
                valueGanttChart[i].ForeColor = Color.Gray;
                valueGanttChart[i].BackColor = Color.Transparent;
                valueGanttChart[i].Visible = false;

                xPos += panelArray[i].Width;
                tabPage_GanttChart.Controls.Add(panelArray[i]);
                tabPage_GanttChart.Controls.Add(valueGanttChart[i]);
            }
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }
    }
}
