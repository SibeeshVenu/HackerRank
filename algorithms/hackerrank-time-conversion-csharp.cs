using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Hacker rank problem link: https://www.hackerrank.com/challenges/time-conversion/problem
       Given a time in -hour AM/PM format, convert it to military (24-hour) time.
       Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
       - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
     */
    static string timeConversion(string s) {
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
