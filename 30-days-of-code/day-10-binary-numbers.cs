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
    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-binary-numbers/problem
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        while (n != 0)
        {
            n = (n & (n << 1));
            counter++;
        }
        Console.WriteLine(counter);
    }
}
