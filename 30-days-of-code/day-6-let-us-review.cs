using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    // Hacker rank problem link: https://www.hackerrank.com/challenges/30-review-loop/problem
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var numberOfTestCases = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfTestCases; i++)
        {
            var strInput = Console.ReadLine();
            var oddString = string.Empty;
            var evenString = string.Empty;
            for (int j = 0; j < strInput.Length; j++)
            {
                if (j % 2 == 0) evenString += strInput[j];
                else oddString += strInput[j];
            }
            var output = $"{evenString} {oddString}";
            Console.WriteLine(output);
        }
    }
}
