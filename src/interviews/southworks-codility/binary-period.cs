
namespace interviews.southworks_codility
{
    public class BinaryPeriod
    {
        /// <summary>
        /// A non-empty zero-indexed string S consisting of Q characters is given. The period of this string is the smallest positive integer P such that:
        /// P ≤ Q / 2 and S[K] = S[K + P] for 0 ≤ K<Q − P.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Solution(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int p;
            while (n > 0)
            {
                d[l] = n % 2;
                n /= 2;
                l++;
            }
            for (p = 1; p < 1 + l / 2; ++p)
            {
                int i;
                bool ok = true;
                for (i = 0; i < l - p; ++i)
                {
                    if (d[i] != d[i + p])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return p;
                }
            }
            return -1;
        }
    }
}
