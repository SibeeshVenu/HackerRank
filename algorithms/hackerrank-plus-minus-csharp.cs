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

    // hacker rank problem link: https://www.hackerrank.com/challenges/plus-minus/problem
    /*
        Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
        Print the decimal value of each fraction on a new line with  places after the decimal.
    */
    static void plusMinus(int[] arr) {
        // Remmeber int/int = int
        double positiveNumbers = 0.00;
        double negativeNumbers = 0.00;
        int length = arr.Length;
        double zeros = 0.00;

        foreach(int num in arr) {
            if(num > 0) ++positiveNumbers;
            else if(num<0) ++negativeNumbers;
            else if(num==0) ++zeros;
        }
        
        Console.WriteLine(((double) (positiveNumbers / length)).ToString("F6"));
        Console.WriteLine(((double) (negativeNumbers / length)).ToString("F6"));
        Console.WriteLine(((double) (zeros / length)).ToString("F6"));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
