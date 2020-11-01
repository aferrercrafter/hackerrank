using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.unpaired_elements
{
    public class UnpairedElements
    {
        public int Solution(int[] A)
        {
            return Solution(A.Where(x => x != A[0]).ToArray(), A[0], A.Length);
        }

        public int Solution(int[] A, int p, int l)
        {
            if (A.Length == 1)
                return A[0];

            if (l - A.Length == 1)
                return p;

            return Solution(A.Where(x => x != A[0]).ToArray(), A[0], A.Length);
        }
    }
}
