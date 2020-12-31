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
    // Hacker rank problem link: https://www.hackerrank.com/challenges/sparse-arrays/problem
    /*
    There is a collection of input strings and a collection of query strings. 
    For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.
    */
    // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries) {
        int[] outputArray= new int[queries.Length];
        for(int i=0; i<queries.Length; i++){
            outputArray[i]=findOccurences(queries[i], strings);
        }
        return outputArray;
    }
    
    private static int findOccurences(string elem, string[] baseArray){
        int c = 0;
        for(int i=0;i<baseArray.Length;i++){
            if(elem.Equals(baseArray[i])) c++;
        }
        return c;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
