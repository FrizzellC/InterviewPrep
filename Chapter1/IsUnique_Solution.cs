using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    class IsUnique_Solution
    {
        public bool isUnique(string input)
        {
            char currChar;
            for (int i = 0; i < input.Length; i++)
            {
                currChar = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j].Equals(currChar))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
