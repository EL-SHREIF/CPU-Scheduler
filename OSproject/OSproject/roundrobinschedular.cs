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
        public int[] ganttChart_RR;
        private int contextSwitch_RR;
        private float Avg_waitingTime_RR;
        public int num_ganttChart_RR;

       public int number_ganttChart = 200;

       public roundrobinschedular()
       {
            int no_of_process = main_menu.MainNumberOfProcesses;
            quantumTime = roundrobin.quantum_time;

            waitingTime_RR = new int[no_of_process];
            turnAroundTime_RR = new int[no_of_process];

            ganttChart_RR = new int[number_ganttChart];

            cpu_brustTime = new int[no_of_process];
            arrivalTime = new int[no_of_process];

            // Initial value in array.
            clearArrayData(); // Clear waiting time.
            for (int i = 0; i < 10; i++)
            {
                cpu_brustTime[i] = 1;
                arrivalTime[i] = 0;
            }

            for (int i = 0; i < number_ganttChart; i++)
            {
                ganttChart_RR[i] = -1;
            }

            num_process = no_of_process;
        }

        public void clearArrayData()
        {
            for (int i = 0; i < 10; i++)
            {
                waitingTime_RR[i] = 0;
                turnAroundTime_RR[i] = 0;
            }
        }

        public void clearDataRR()
        {
            for (int i = 0; i < 10; i++)
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

        public int getContextSwitch_RR()
        {
            return contextSwitch_RR;
        }
        
        public void computeRR()
        {
            int n = num_process, index_min = 0;
            int index_process_before = -1; // not execute.
            int min_arrival;
            int j;
            int myQuantumTime = quantumTime;

            process myData;

            List<int> temp = new List<int>();
            Queue<process> queueWaiting = new Queue<process>();
            List<process> myList = new List<process>();

            int count_process_incomplete = num_process;

            for (int i = 0; i < num_process; i++)
            {
                myList.Add(new process(i, arrivalTime[i], cpu_brustTime[i]));
            }

            int count = 0;
            int temp_index = 0;
            while (count_process_incomplete > 0)
            { 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                            index_min = myList[i].index;
                            min_arrival = myList[i].arrival;
                            temp_index = j; 
                        }
                        if (myList[i].arrival <= count)
                        {
                            // Add process to waiting queue.
                            queueWaiting.Enqueue(new process(myList[i].index, myList[i].arrival, myList[i].burst_time));
                            temp.Add(i); // for delete later. 
                            // can not delete here because it effect with loop.
                        }
                    }

                    if (queueWaiting.Count == 0)
                    {
                        while (count < min_arrival)
                        {
                            ganttChart_RR[count] = -1;
                            count++;
                        }
                    }
                }

                //delete value in list after move to QueueWaiting.
                while (temp.Count != 0)
                {
                    int temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp_del);
                    temp.Remove(temp_del);
                }

                //queueWaiting.Add(myList[temp_index]);
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    myData = queueWaiting.Dequeue();

                    if (index_process_before == -1)
                    {
                        index_process_before = myData.index;
                        waitingTime_RR[myData.index] = count;
                    }
                    else if (index_process_before != myData.index)
                    {
                        waitingTime_RR[myData.index] += count - turnAroundTime_RR[myData.index];
                        turnAroundTime_RR[index_process_before] = count;
                        contextSwitch_RR++;
                    }
                    index_process_before = myData.index;

                    // Excute 1 ms.
                    for (int i = 0; i < myQuantumTime && myData.burst_time>0; i++)
                    {
                        myData.burst_time--;
                        if (count < number_ganttChart)
                        {
                            ganttChart_RR[count] = myData.index;
                        }
                        count++;
                    }

                    if (myData.burst_time == 0)
                    {
                        count_process_incomplete--;
                        turnAroundTime_RR[myData.index] = count;
                        myData = null;
                    }
                    else
                    {
                        queueWaiting.Enqueue(new process(myData.index,myData.arrival,myData.burst_time));
                    }   
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_RR = number_ganttChart;
            }
            else
            {
                num_ganttChart_RR = count;
            }

            for (int i = 0; i < num_process; i++)
            {
                waitingTime_RR[i] = waitingTime_RR[i] - arrivalTime[i];
            }

            turnAroundTime_RR[index_process_before]++; // increase last 1 ms last process . 
            Avg_waitingTime_RR = waitingTime_RR.Sum() / (float)num_process;
        } 
    }
}
