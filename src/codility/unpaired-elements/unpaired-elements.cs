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
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (d.TryGetValue(A[i], out int count))
                {
                    d[A[i]] = count + 1;
                }
                else
                {
                    d[A[i]] = 1;
                }
            }

            foreach (KeyValuePair<int, int> v in d)
            {
                if (v.Value % 2 != 0)
                    return v.Key;
            }

            return -1;
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
