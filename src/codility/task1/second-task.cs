using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.task1
{
    public class SecondTask
    {
        public string Solution(string S)
        {
            int i;
            for(i = 0; i < S.Length - 1; i++)
            {
                if (S[i] > S[i + 1])
                    break;
            }
            return S.Remove(i, 1);
        }
    }
}
