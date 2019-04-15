using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSproject
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
        public process(int i,int value,int b)
        { 
            index =i;
            arrival = value;
            burst_time = b;
        }

        public process(int i, int value, int b, int p)
        { 
            index =i;
            arrival = value;
            burst_time = b;
            priority = p;
        }
    }
}
