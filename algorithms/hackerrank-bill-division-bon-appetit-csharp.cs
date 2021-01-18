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
    /*
      Hackerrank problem link: https://www.hackerrank.com/challenges/bon-appetit/problem
      Two friends Anna and Brian, are deciding how to split the bill at a dinner. 
      Each will only pay for the items they consume. 
      Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.
      Complete the bonAppetit function in the editor below. 
      It should print Bon Appetit if the bill is fairly split. 
      Otherwise, it should print the integer amount of money that Brian owes Anna.
    */
    static void bonAppetit(List<int> bill, int k, int b)
    {
        bill.RemoveAt(k);
        int actual = bill.Sum() / 2;
        if (actual == b) Console.WriteLine("Bon Appetit");
        else Console.WriteLine(b - actual);
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
