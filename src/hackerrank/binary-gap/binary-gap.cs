using System;

namespace hackerrank
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            string b = Convert.ToString(N, 2);

            if (!b.Substring(1, b.Length - 1).Contains("1"))
                return 0;

            int max = 0;
            int seq = 0;
            for (int i = 1; i < b.Length - 1; i++)
            {
                if (b[i] == '0')
                {
                    seq++;
                    if (b[i + 1] == '1')
                    {
                        if (max < seq)
                        {
                            max = seq;
                            if (max >= b.Length - i - 1)
                                break;
                        }

                        seq = 0;
                    }
                }
            }

            return max;
        }
    }
}
