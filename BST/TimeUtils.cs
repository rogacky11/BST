using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BST
{
    public static class TimeUtils
    {
        public static long GetNanoseconds()
        {
            long nanoseconds = Stopwatch.GetTimestamp() * (1000000000L / Stopwatch.Frequency);
            return nanoseconds;
        }
    }
}
