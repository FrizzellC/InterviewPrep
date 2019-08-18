using System;

namespace PracticeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] input = new char[] { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', ' ', ' ' };
            string result = URLify(input, 11);
        }

        public static string URLify(char[] input, int occupied)
        {
            double numberOfUnusedSpaces = (input.Length - occupied);
            int spaces = (int)Math.Ceiling(numberOfUnusedSpaces / 2);
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (numberOfUnusedSpaces != 0)
                {
                    char current = input[i];
                    if (Char.IsWhiteSpace(current))
                    {
                        input[i] = '%';
                        input = MoveCharsToRight(input, i);
                        input[i + 1] = '2';
                        input[i + 2] = '0';
                        numberOfUnusedSpaces--;
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
