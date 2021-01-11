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

    // hacker rank problem link: https://www.hackerrank.com/challenges/staircase/problem
    /*
        Its base and height are both equal to n. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
        Write a program that prints a staircase of size n.
    */
    static void staircase(int n) {   
           /* With the String constructor we can say how many character should be created
              PadLeft will align the values left to right
              PadRight will align items from right to left
           */
       for(int i=0; i<n; i++) {
           Console.WriteLine(new String('#', i+1).PadLeft(n, ' '));
       }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
