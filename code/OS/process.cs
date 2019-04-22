using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class process
    {
        public int arrival;
        public int index;
        public int burst_time;
        public int priority;

        public process()
        {

        }
        public process(int i, int value, int b)
        {
            index = i;
            arrival = value;
            burst_time = b;
        }

        public process(int i, int value, int b, int p)
        {
            index = i;
            arrival = value;
            burst_time = b;
            priority = p;
        }

        public static void sort1(List<process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].arrival < l[j].arrival)
                    {
                        process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }

        public static void sort2(List<process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].priority < l[j].priority)
                    {
                        process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
        public static void sort3(List<process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].burst_time < l[j].burst_time)
                    {
                        process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }

        }
    }
}
