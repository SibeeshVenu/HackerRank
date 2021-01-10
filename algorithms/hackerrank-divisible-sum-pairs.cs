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

class Solution {

    // Hacker rank problem link: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
    /*
      Complete the divisibleSumPairs function in the editor below. It should return the integer count of pairs meeting the criteria.

        divisibleSumPairs has the following parameter(s):

        n: the integer length of array 
        ar: an array of integers
        k: the integer to divide the pair sum by
    */
    static int divisibleSumPairs(int n, int k, int[] ar) {
        int count = 0;
        for(int i = 0; i< n; i++) {
            for(int j = i+1; j< n; j++) {
                if((ar[i]+ar[j]) % k == 0) {
                    count++;
                }
            }
        }
        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
