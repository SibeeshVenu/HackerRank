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

    // Hacker rank problem: https://www.hackerrank.com/challenges/mini-max-sum/problem?h_r=next-challenge&h_v=zen
    /*
        Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
        Then print the respective minimum and maximum values as a single line of two space-separated long integers.
    */
    static void miniMaxSum(int[] arr) {
        // This is needed as we get int overflow error, so to fix it cast it to long
        long arraySum = arr.Sum(s=>(long)s);        
        Console.WriteLine($"{arraySum - arr.Max()} {arraySum - arr.Min()}");
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
