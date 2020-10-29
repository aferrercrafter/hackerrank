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
            var counters = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                counters.Add(i, 0);
            }

            int max = 0;

            foreach(int x in A)
            {
                if (x != (N + 1))
                {
                    counters[x - 1] = counters[x - 1] + 1;
                    max = Math.Max(counters[x - 1], max);
                }
                else
                    for (int i = 0; i < N; i++)
                        counters[i] = max;
            }

            return counters.Select(x => x.Value).ToArray();
        }
    }
}
