using System;

namespace PracticeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = "acto cat";
            Chapter1.PalindromePermutation test = new Chapter1.PalindromePermutation();
            bool result = test.isPalindromePermutation(input);
            
        }

    }
}
