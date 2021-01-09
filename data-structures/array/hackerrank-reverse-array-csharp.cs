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
    // Hacker rank problem link: https://www.hackerrank.com/challenges/arrays-ds/problem
    /*
    An array is a type of data structure that stores elements of the same type in a contiguous block of memory. 
    In an array, , of size , each memory location has some unique index,  (where ), that can be referenced as  or .
    Reverse an array of integers.
    */
    // Complete the reverseArray function below.
    static int[] reverseArray(int[] a) {
        return a.Reverse().ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] res = reverseArray(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
