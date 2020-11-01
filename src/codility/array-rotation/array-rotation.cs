using System;
using System.Collections.Generic;
using System.Text;

namespace codility.array_rotation
{
    public class ArrayRotation
    {
        public int[] Solution(int[] A, int K)
        {
            int[] S = new int[A.Length];

            if (A == null)
                return S;

            if (A.Length == 0)
                return S;

            int p;
            for (int i = 0; i < A.Length; i++)
            {
                p = (K + i) % A.Length;
                S[p] = A[i];
            }

            return S;
        }
    }
}
