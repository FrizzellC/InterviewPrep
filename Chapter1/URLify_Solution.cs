using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    public class URLify_Solution
    {
        public static string URLify(char[] input, int occupied)
        {
            double numberOfTrailingSpaces = (input.Length - occupied);
            int spaces = (int)Math.Ceiling(numberOfTrailingSpaces / 2);
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (spaces != 0)
                {
                    char current = input[i];
                    if (Char.IsWhiteSpace(current))
                    {
                        input[i] = '%';
                        input = MoveCharsToRight(input, i);
                        input[i + 1] = '2';
                        input[i + 2] = '0';
                        spaces--;
                    }
                    else
                    {
                        input[i] = input[i];
                    }
                }
                else
                {
                    break;
                }
            }

            foreach (char c in input)
            {
                result += c;
            }
            return result;
        }

        public static char[] MoveCharsToRight(char[] inputArray, int index)
        {
            for (int i = inputArray.Length - 1; i > index; i--)
            {
                inputArray[i] = inputArray[i - 2];
            }
            return inputArray;
        }
    }
}
