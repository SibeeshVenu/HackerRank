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

    // Hackerrank problem link: https://www.hackerrank.com/challenges/30-operators/problem
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
     var output = meal_cost+((meal_cost*tip_percent)/100)+((meal_cost*tax_percent)/100);
     Console.WriteLine(Math.Round(output));
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}
