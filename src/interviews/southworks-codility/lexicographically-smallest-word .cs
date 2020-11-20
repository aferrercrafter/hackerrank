using System;
using System.Collections.Generic;
using System.Text;

namespace interviews.southworks_codility
{
    public class LexicographicallySmallestWord
    {
        /// <summary>
        /// Lexicographically smallest string formed by removing at most one character
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public string Solution(string S)
        {
            int i;
            for (i = 0; i < S.Length - 1; i++)
            {
                if (S[i] > S[i + 1])
                    break;
            }
            return S.Remove(i, 1);
        }
    }
}
