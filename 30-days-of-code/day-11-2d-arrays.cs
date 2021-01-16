using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // Hackerrak problem link: https://www.hackerrank.com/challenges/30-2d-arrays/problem
    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        List<int> sum = new List<int>();
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                int topSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                int middleSum = arr[i + 1][j + 1];
                int bottomSum = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                sum.Add(topSum + middleSum + bottomSum);
            }
        }
        Console.WriteLine(sum.Max());
    }
}
