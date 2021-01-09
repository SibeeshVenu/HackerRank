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

    // Hacker rank problem link: https://www.hackerrank.com/challenges/palindrome-index/problem
    /*
        Given a string of lowercase letters in the range ascii[a-z], determine the index of a character that can be removed to make the string a palindrome. 
        There may be more than one solution, but any will do. If the word is already a palindrome or there is no solution, return -1. Otherwise, return the index of a character to remove.
    */
    static int palindromeIndex(string s) {
        if(isPalindrome(s)) return -1;
        int start = 0;
        int end = s.Length - 1;
        while(true)
        {
            if(s[start] == s[end])
            {                
                start++;
                end--;
                continue;
            }
            
            if(isPalindrome(s.Remove(start,1))) return start;
            else if(isPalindrome(s.Remove(end,1))) return end;
            else return -1;
        }
        
    }
    
    static bool isPalindrome(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
