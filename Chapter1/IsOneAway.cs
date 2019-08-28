using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    public class IsOneAway
    {
        public bool isAtMostOneEditAway(string a, string b)
        {
            int difference = Math.Abs(a.Length) - Math.Abs(b.Length);
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
    }
}
