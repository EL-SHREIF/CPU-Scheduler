using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class P_alg
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


        public P_alg(int[] a, int[] b, int[] c,int n)
        {
            num_process = n;
            arrivalTime = a;
            cpu_brustTime = b;
            priority = c;
            waitingTime = new int[2000];
            turnaroundTime = new int[2000];
            start = new int[2000];
            end = new int[2000];
            proc = new int[2000];
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

        public void computePriority_N()
        {
            List<process> p = new List<process>(num_process);

            for (int i = 0; i < num_process; i++)
            {
                p.Add(new process(i, arrivalTime[i], cpu_brustTime[i],priority[i]));
            }
            process.sort1(p);
            int cnt = 0;
            int idx = 0;

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
                    process.sort2(ready);
                    process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    start[idx] = cnt;
                    end[idx] = cnt + readyProcess.burst_time;
                    proc[idx] = readyProcess.index;
                    waitingTime[idx] = start[idx] - readyProcess.arrival;
                    turnaroundTime[idx] = end[idx] - readyProcess.arrival;
                    idx++;
                    cnt += readyProcess.burst_time;
                    for (int i = 0, j = 0; i < p.Count; i++)
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
        public void computePriority_P()
        {
            List<process> p = new List<process>(num_process);
            for (int i = 0; i < num_process; i++)
            {
                p.Add(new process(i, arrivalTime[i], cpu_brustTime[i], priority[i]));
            }
            process.sort1(p);
            int cnt = 0;
            int idx = -1;
            if (p[0].arrival > cnt)
            {idx = 0;}
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
                int cur = -2;
                while (ready.Count != 0)
                {   
                    process.sort2(ready);
                    process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (cur != readyProcess.index)
                    {
                        idx++;
                        start[idx] = cnt;
                        proc[idx] = readyProcess.index;

                        readyProcess.burst_time--;
                        cur = readyProcess.index;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.burst_time > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        else
                        {
                            

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
                    else
                    {
                        readyProcess.burst_time--;
                        cur = readyProcess.index;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.burst_time > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        else
                        {
                            

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
            lastValid = idx + 1;

        }
    }
}
