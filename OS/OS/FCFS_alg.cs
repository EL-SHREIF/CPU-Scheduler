using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class FCFS_alg
    {
        //inputs
		public int num_process;
        public int[] cpu_brustTime;
        public int[] arrivalTime;
        public int[] priority;

		//outputs
        public int[] waitingTime;
        public int[] turnaroundTime;
        public int[] start;
        public int[] end;
        public int[] proc;
        public float avg_waiting;
        public float avg_turnaround;
        public int lastValid;

        public FCFS_alg(int[] a, int[] b, int[] c, int num)
        {
            num_process = num;
            arrivalTime = a;
            cpu_brustTime = b;
            priority = c;
            waitingTime = new int[2000];
            turnaroundTime = new int[2000];
            start = new int[2000];
            end = new int[2000];
            proc = new int[2000];
            for(int i = 0; i < 2000; i++)
            {
                waitingTime[i] = 0; turnaroundTime[i] = 0; start[i] = 0; end[i] = 0; proc[i] = -1;
            }

        }
        public void clearData()
        {
            arrivalTime = new int[0]; cpu_brustTime = new int[0]; priority = new int[0];
            for (int i = 0; i < 2000; i++)
            {
                waitingTime[i] = 0; turnaroundTime[i] = 0; start[i] = 0; end[i] = 0; proc[i] = -1;
            }
        }
        public void computeFCFS()
        {
            List<process> p = new List<process>(num_process);
           
            for (int i = 0; i < num_process; i++)
            {
                p.Add (new process(i, arrivalTime[i], cpu_brustTime[i]));
            }

            process.sort1(p);
           

            int cnt = 0,idx = 0;
            for(int i = 0; i < num_process; i++)
            {
                if (p[i].arrival <= cnt)
                {
                    start[idx] = cnt;
                    end[idx] = cnt + p[i].burst_time;
                    proc[idx] = p[i].index;
                    waitingTime[i] = start[idx] - p[i].arrival;
                    turnaroundTime[i] = end[idx] - p[i].arrival;
                    cnt += p[i].burst_time;
                    idx++;
                }
                else
                {
                    start[idx] = cnt;
                    end[idx] = p[i].arrival;
                    proc[idx] = -1;
                    cnt = p[i].arrival;
                    idx++;
                    start[idx] = cnt;
                    end[idx] = cnt + p[i].burst_time;
                    proc[idx] = p[i].index;
                    waitingTime[i] = start[idx] - p[i].arrival;
                    turnaroundTime[i] = end[idx] - p[i].arrival;
                    cnt += p[i].burst_time;
                    idx++;
                }
            }
            for(int i = 0; i <num_process; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= num_process;
            for (int i = 0; i < num_process; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= num_process;
            lastValid = idx;
        }
    }
}
