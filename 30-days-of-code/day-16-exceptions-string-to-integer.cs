using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        try
        {
            Console.WriteLine(Convert.ToInt64(S));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bad String");
        }
    }
}
