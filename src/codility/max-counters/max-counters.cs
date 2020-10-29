using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.max_counters
{
    public class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            var counters = new int[N];
            int max = 0;
            int min = 0;

            foreach(int x in A)
            {
                if (x != (N + 1))
                {
                    if (counters[x - 1] < min)
                        counters[x - 1] = min;
                    counters[x - 1] = counters[x - 1] + 1;
                    max = Math.Max(counters[x - 1], max);
                }
                else
                    min = max;
            }

            for (int i = 0; i < N; i++)
                counters[i] = Math.Max(counters[i], min);

            return counters;
        }
    }
}
