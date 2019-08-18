using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    public class StringCompression_Solution
    {
        public string Compress(string toCompress)
        {
            if (toCompress.Length <= 1)
            {
                return toCompress;
            }
            else if (toCompress.Length == 2)
            {
                if (toCompress[0].Equals(toCompress[1]))
                {
                    return toCompress[0] + "2";
                }
            }

            string result = toCompress[0].ToString();
            int count = 1;
            int length = toCompress.Length;

            for (int i = 1; i < length; i++)
            {
                if (toCompress[i].Equals(toCompress[i - 1]))
                {
                    count++;
                }
                else
                {
                    result += count.ToString();
                    count = 1;
                    result += toCompress[i];
                }
            }

            result += count.ToString();

            if (result.Length <= toCompress.Length)
            {
                return result;
            }
            return toCompress;
        }
    }
}
