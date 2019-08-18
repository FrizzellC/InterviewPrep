using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    public class IsPermutation_Solution
    {
        // SOLUTION
        // Problem 1.3, P90
        // Assumption: ASCII (I realize a abd b are sequences of UTF16, but for simplicity sake, 
        // I am choosing to assume ASCII values)
        public bool IsPermutation(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int[] occurrencesInA = GetOccurenceCounts(a);
            int[] occurrencesInB = GetOccurenceCounts(b);

            for (int i = 0; i < occurrencesInA.Length; i++)
            {
                if (occurrencesInA[i] != occurrencesInB[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int[] GetOccurenceCounts(string input)
        {
            int[] occurrences = new int[128];
            char currChar;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                currChar = input[i];
                int index = (Int32)currChar;

                if (occurrences[index] != 0)
                {
                    foreach (char item in input)
                    {
                        if (item.Equals(currChar))
                        {
                            count++;
                        }
                    }
                    occurrences[index] = count;
                    count = 0;
                }
            }

            return occurrences;
        }
    }
}
