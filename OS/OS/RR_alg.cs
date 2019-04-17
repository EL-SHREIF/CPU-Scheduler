using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class RR_alg
    {
 
        public int quantum;
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


        public RR_alg(int[] a, int[] b, int[] c, int q,int num)
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
            quantum = q;
            for (int i = 0; i < 2000; i++)
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

        public void computeRR()
        {
            List<process> p = new List<process>(num_process);
            for (int i = 0; i < num_process; i++)
            {
                p.Add(new process(i, arrivalTime[i], cpu_brustTime[i]));
            }
            process.sort1(p);

            int cnt = 0, idx = 0;
            while (p.Count != 0)
            {
                List<process> ready = new List<process>(num_process);
                if (p.First().arrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = p.First().arrival;
                    proc[idx] = -1;
                    idx++;
                    cnt = p.First().arrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].arrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;

                }
                while (ready.Count != 0)
                {
                    process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (quantum < readyProcess.burst_time)
                    {
                        start[idx] = cnt;
                        end[idx] = cnt + quantum;
                        proc[idx] = readyProcess.index;
                        cnt += quantum;
                        readyProcess.burst_time -= quantum;
                        ready.Add(readyProcess);
                        idx++;
                    }
                    else
                    {
                        start[idx] = cnt;
                        end[idx] = cnt + readyProcess.burst_time;
                        proc[idx] = readyProcess.index;
                        cnt += readyProcess.burst_time;
                        idx++;
                    }
                    for (int i = 0, j = 0; j < p.Count; i++)
                    {
                        if (p[j].arrival <= cnt)
                        {
                            ready.Add(p[j]);
                            p.RemoveAt(j);
                        }
                        else j++;

                    }

                }
            }
            for (int j = 0; j < num_process; j++)
            {
                bool k = false; int wait = 0;
                for (int i = 0; i <= idx; i++)
                {
                    if (proc[i] == j)
                    {
                        if (!k)
                        {
                            waitingTime[j] = start[i] - arrivalTime[j]; k = true;
                            wait = end[i];

                        }
                        else if (k)
                        {
                            waitingTime[j] += start[i] - wait;
                            wait = end[i];
                        }
                        turnaroundTime[j] = wait - arrivalTime[j];
                    }
                }
            }
            for (int i = 0; i < num_process; i++)
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
