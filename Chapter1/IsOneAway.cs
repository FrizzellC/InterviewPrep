using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    public class IsOneAway
    {
        public bool isAtMostOneEditAway(string a, string b)
        {
            string longestString = GetLongestString(a, b);
            string shortestString = GetShortestString(a, b);

            int difference = longestString.Length - shortestString.Length;

            if (difference > 1)
            {
                return false;
            }

            int combinedLength = a.Length + b.Length;
            HashSet<char> set = new HashSet<char>();

            foreach (char x in a)
            {
                set.Add(x);
            }
            foreach (char y in b)
            {
                set.Add(y);
            }

            if (set.Count - combinedLength > 1)
            {
                return false;
            }
            return true;
        }

        public string GetLongestString(string a, string b)
        {
            if (a.Length >= b.Length)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public string GetShortestString(string a, string b)
        {
            if (a.Length >= b.Length)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
