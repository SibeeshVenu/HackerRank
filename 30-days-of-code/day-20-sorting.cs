using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-sorting/problem
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int length = a.Length - 1;
        int numSwaps = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    numSwaps++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[length]}");
    }
}
