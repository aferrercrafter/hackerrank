using System;
using System.Collections.Generic;
using System.Text;

namespace interviews.southworks_codility
{
    public class DaysPermutation
    {
        /// <summary>
        /// Given a specific date, and a number K, return the day on the week after K permutations.
        /// </summary>
        /// <param name="S">Day of the week</param>
        /// <param name="K">Permutations</param>
        /// <returns></returns>
        public string Solution(string S, int K)
        {
            string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            //Dictionary<string, int> days = new Dictionary<string, int>();

            int pos = 0;
            for (int i = 0; i < 7; i++)
            {
                if (string.Equals(days[i], S))
                {
                    pos = i;
                    break;
                }
            }

            pos = (K + pos) % 7;

            return days[pos];

        }
    }
}
