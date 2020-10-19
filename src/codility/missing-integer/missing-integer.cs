using System.Linq;

namespace codility.missing_integer
{
    public class MissingInteger
    {
        public int Solution(int[] A)
        {
            int[] sorted = A.OrderBy(x => x).ToArray();
            int min = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (sorted[i] == min)
                    min++;

                if (sorted[i] > min)
                    return min;
            }

            return min++;
        }
    }
}
