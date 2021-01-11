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

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
       Hacker rank problem link: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
       You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. 
       They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
     */
    
    public static int birthdayCakeCandles(List<int> candles)
    {
        // we need the casting here to get rid of overflow exception
        // find the max, and get the count of the max value occurence
        long max = candles.Max(m=>(long)m);
        return candles.Where(v=>(long)v==max).Count();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
