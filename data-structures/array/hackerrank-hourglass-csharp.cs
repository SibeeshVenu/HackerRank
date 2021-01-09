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

    // Hourglass problem link: https://www.hackerrank.com/challenges/2d-array/problem
    /*
    An hourglass sum is the sum of an hourglass' values. 
    Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. The array will always be .
    */
   // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        // The array is 2 Dimention 6 x 6 
        // We can form 4 x 4 = 16 hourglasses
        // Create 2 loops, one for the row and other for the column
        // i,j=0 && i,j <=3, remember that we can form 4 x 4 = 16 hourglasses
        var sumList = new List<int>();
        for(int i=0; i<=3; i++) {
            for(int j=0; j<= 3; j++) {
                var firstRowSum = arr[i][j]+arr[i][j+1]+arr[i][j+2];
                var middleItem = arr[i+1][j+1];
                var thirdRowSum = arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                sumList.Add(firstRowSum+middleItem+thirdRowSum);
            }
        }
        return sumList.Max();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
