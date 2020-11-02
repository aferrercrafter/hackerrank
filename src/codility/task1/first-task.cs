using System;
using System.Collections.Generic;
using System.Text;

namespace codility.task1
{
    public class FirstTask
    {
        public string Solution(string S, int K)
        {
            string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            //Dictionary<string, int> days = new Dictionary<string, int>();

            int pos = 0;
            for(int i = 0; i < 7; i++)
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
