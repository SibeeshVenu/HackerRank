using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    /*  Hacker Rank Problem Link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
        Given  names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. 
        You will then be given an unknown number of names to query your phone book for. 
        For each  queried, print the associated entry from your phone book on a new line in the form name=phoneNumber; 
        if an entry for  is not found, print Not found instead.
    */
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        var phoneBook = new Dictionary<string, string>();
        // Add the values to the Dictionary
        for(int i=1; i<=n;i++) {
            var readLine = Console.ReadLine().Split(' ');   
            phoneBook.Add(readLine[0], readLine[1]);            
        }
        // As there is unknown queries, we can't use a for loop here
        // Thus using a do-while loop
        var query = Console.ReadLine();     
        do 
        {                   
            if(phoneBook.ContainsKey(query))
                Console.WriteLine($"{query}={phoneBook[query]}");
            else
                Console.WriteLine("Not found");  
            // assign the query again here, for the next
            query = Console.ReadLine();
        } while (!string.IsNullOrWhiteSpace(query));
    }
}