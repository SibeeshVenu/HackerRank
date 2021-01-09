using System;
using System.Linq;

class Difference {
    /*
    Hackerrank problem link: https://www.hackerrank.com/challenges/30-scope/problem?h_r=profile
    The absolute difference between two integers,  and , is written as . The maximum absolute difference between two integers in a set of positive integers, , is the largest absolute difference between any two integers in .

        The Difference class is started for you in the editor. It has a private integer array () for storing  non-negative integers, and a public integer () for storing the maximum absolute difference.

        Task
        Complete the Difference class by writing the following:

        A class constructor that takes an array of integers as a parameter and saves it to the  instance variable.
        A computeDifference method that finds the maximum absolute difference between any  numbers in  and stores it in the  instance variable.
    */
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    
    public Difference(int[] elements)
    {
        this.elements = elements;
    }
    
    public void computeDifference()
    {
        Array.Sort(elements);
        maximumDifference = elements[elements.Length - 1] - elements[0];
    }

}

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}