using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-data-types/problem
    static void Main(String[] args) {
        // Declare second integer, double, and String variables.
        int a;
        double b;
        string c;
        // Read and save an integer, double, and String to your variables.
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+a);
        // Print the sum of the double variables on a new line.
        Console.WriteLine((b+d).ToString("0.0"));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(string.Concat(s,c));
    }
}