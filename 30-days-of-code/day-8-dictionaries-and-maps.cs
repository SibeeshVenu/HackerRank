using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Hackerrank problem link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem */
        
        int n = Convert.ToInt32(Console.ReadLine());
        var phoneBook = new Dictionary<string, string>();
        for (int i = 1; i <= n; i++)
        {
            var readLine = Console.ReadLine().Split(' ');
            phoneBook.Add(readLine[0], readLine[1]);
        }
        var query = Console.ReadLine();
        do
        {
            if (phoneBook.ContainsKey(query))
            {
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            query = Console.ReadLine();
        } while (!string.IsNullOrWhiteSpace(query));
    }
}
