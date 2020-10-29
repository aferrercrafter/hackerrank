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

            for (int i = 0; i < A.Length; i++)
            {
                if (!posCount.Contains(A[i]))
                    posCount.Add(A[i]);

                if (posCount.Count == X)
                    return i;
            }

            return -1;
        }
    }
}
