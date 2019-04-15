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
        public RR_output()
        {
            InitializeComponent();
        }
        public void DrawGanttChart()
        {
            int xPos = 9, yPos = 10;
            tabPage_GanttChart.AutoScroll = true;
            tabPage_GanttChart.VerticalScroll.LargeChange = tabPage_GanttChart.VerticalScroll.Maximum / 2;
            for (int i = 0; i < myScheduling.number_ganttChart; i++)
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
