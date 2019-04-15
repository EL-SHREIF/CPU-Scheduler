using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OSproject
{
   public class roundrobinschedular
    {
        public int num_process;

        public int[] cpu_brustTime;
        public int[] arrivalTime;
        public int[] priority;
        public int quantumTime;
        
        // After Process         
        public int[] waitingTime_RR;
        public int[] turnAroundTime_RR;

        public int[] start;
        public int[] end;
        public int[] process;
        
        private float Avg_waitingTime_RR;
        public int num_ganttChart_RR;

        public int number_ganttChart = 2000;

       public roundrobinschedular()
       {
            int no_of_process = main_menu.MainNumberOfProcesses;
            quantumTime = roundrobin.quantum_time;

            waitingTime_RR = new int[no_of_process];
            turnAroundTime_RR = new int[no_of_process];

            cpu_brustTime = new int[no_of_process];
            arrivalTime = new int[no_of_process];
            start = new int[2000];
            end = new int[2000];
            process= new int[2000];

            // Initial value in array.
            clearArrayData(); // Clear waiting time.
            for (int i = 0; i < num_process; i++)
            {
                cpu_brustTime[i] = 1;
                arrivalTime[i] = 0;
            }

            for (int i = 0; i < number_ganttChart; i++)
            {
                start[i] = -1;
                end[i] = -1;
                process[i] = -1;
            }

            num_process = no_of_process;
        }

        public void clearArrayData()
        {
            for (int i = 0; i < num_process; i++)
            {
                waitingTime_RR[i] = 0;
                turnAroundTime_RR[i] = 0;
            }
        }

        public void clearDataRR()
        {
            for (int i = 0; i < num_process; i++)
            {
                waitingTime_RR[i] = 0;
                turnAroundTime_RR[i] = 0;
            }
        }


        public void setq( int data)
        {
            quantumTime=data;
        }

    
        // Set and Get CPU Brust Time.
        public void setBrustTime(int index,int data){
            cpu_brustTime[index] = data;
        }

        public int getBrustTime(int index)
        {
            return cpu_brustTime[index];
        }

        // Set and Get Arrival Time.
        public void setArrivalTime(int index, int data)
        {
            arrivalTime[index] = data;
        }

        public int getArrivalTime(int index)
        {
            return arrivalTime[index];
        }

        //Set and Get Number of Process.
        public void setNumberProcess(int value)
        {
            num_process = value;
        }

        public int getNumberProcess()
        {
            return num_process;
        }


        public float getAVG_waitingTimeRR()
        {
            return Avg_waitingTime_RR;
        }

        public void computeRR()
        {
            int n = num_process, index_min = 0;
            int index_process_before = -1; // not execute.
            int min_arrival;
            int j;
            int q = quantumTime;

            process myData;

            List<int> temp = new List<int>();

            Queue<process> queueWaiting = new Queue<process>();
            List<process> myList = new List<process>();

            bool [] finished= new bool [50];
            bool [] taken= new bool [50];

            int count_process_incomplete = num_process;

            for (int i = 0; i < num_process; i++)
            {
                myList.Add(new process(i, arrivalTime[i], cpu_brustTime[i]));
                finished[i]= false;
                taken[i]= false;
            }

            bool end_all=true;
            int time=0;
            int no = 0;
             bool ok = false;
            while (end_all)
            {
                for (int i = 0; i < num_process; i++)
                {
                    if (time >= arrivalTime[i] && taken[i] == false)
                    {
                        taken[i] = true;
                        queueWaiting.Enqueue(myList[i]);
                    }
                }
                bool idle=false;
                process p1;
                if(queueWaiting.Count==0)
                {
                   p1=new process(1000,-1,-1);
                    idle = true;
                }
                else
                   {p1 = queueWaiting.Dequeue();}
                start[no] = time;
                process[no] = p1.index;
                for (int i = 0; i < q; i++) {
                    time++;
                    if(idle){
                        for (int jj = 0; jj < num_process; jj++)
                             {
                              if (time >= arrivalTime[jj] && taken[jj] == false)
                              {
                                 taken[jj] = true;
                                 queueWaiting.Enqueue(myList[jj]);
                              }
                           }
                    }
                    else{
                        p1.burst_time--;
                          for (int k = 0; k < num_process; k++)
                             {
                              if (time >= arrivalTime[k] && taken[k] == false)
                              {
                                 taken[k] = true;
                                 queueWaiting.Enqueue(myList[k]);
                             }
                           }
                            if (p1.burst_time == 0)
                             break;
                         } 
                }
                end[no] = time;
                if (p1.burst_time != 0)
                    queueWaiting.Enqueue(p1);
                else
                    finished[p1.index] = true;
                no++;
                ok = true;
                for (int i = 0; i < num_process; i++)
                {
                    if (!taken[i]) {
                        ok = false;
                    }
                }
                if(ok & queueWaiting.Count==0)
                    end_all=false;
            }
        }   
    }
}
