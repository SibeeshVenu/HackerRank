using System;
using System.Linq;

// Hackerrank problem link: https://www.hackerrank.com/challenges/30-scope/problem
class Difference
{
    private int[] elements;
    public int maximumDifference;
    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        Array.Sort(elements);
        maximumDifference = elements[elements.Length - 1] - elements[0];
    }
} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}