using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.frog_river_one
{
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            HashSet<int> posCount = new HashSet<int>();

            if (A.Length == 0)
                return -1;

            if (X == 0)
                return 0;

            if (X > A.Length)
                return -1;

            long sum = (X * (X + 1L) / 2L);
            long sumT;

            for (int i = 0; i <= A.Length; i++)
            {
                if (!posCount.Contains(A[i]))
                    posCount.Add(A[i]);

                sumT = 0;
                foreach(var kv in posCount)
                {
                    sumT += kv;
                }

                if (sumT == sum)
                    return i;

            }

            return -1;
        }
    }
}
