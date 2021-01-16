using System;

// Hackerrank problem link: https://www.hackerrank.com/challenges/30-generics/problem
class Printer
{

    /**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
    public static void PrintArray<T>(T[] arr)
    {
        foreach (T itm in arr)
        {
            Console.WriteLine(itm);
        }
    }


    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] intArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        n = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        PrintArray<Int32>(intArray);
        PrintArray<String>(stringArray);
    }
}