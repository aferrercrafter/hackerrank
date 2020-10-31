using System;

namespace codility.tape_equilibrium
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {
            if (A == null)
                return 0;

            if (A.Length == 0)
                return 0;

            long sumR = 0;
            long sumL = 0;
            long dif = long.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {   
                sumR += A[i];
            }

            for(int i = 1; i < A.Length; i++)
            {
                sumL += A[i - 1];
                sumR -= A[i - 1];
                dif = Math.Min(dif, Math.Abs(sumR - sumL));
            }

            return (int)dif;
        }
    }
}
