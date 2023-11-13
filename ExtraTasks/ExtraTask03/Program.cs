/* 

В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125.

 */

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] M = new int[100];

        Count(M);
        PrintElements(M);
    }

    private static void Count(int[] M)
    {
        for (int i = 0; i < M.Length; i++)
        {
            M[i]++;
        }
    }

    private static void PrintElements(int[] M)
    {
        for (int i = 0; i < M.Length; i++)
        {
            Console.WriteLine($"{i}: {M[i]}");
        }
    }
}

/* 

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] countArray = { 50, 60, 70, 70, 75, 85, 90, 95, 95, 100, 100, 100, 110, 115, 120, 125 };
        int[] M = new int[100];

        Count(countArray, M);
        PrintElements(M);
    }

    private static void Count(int[] countArray, int[] M)
    {
        foreach (int i in countArray)
        {
            if (0 < i && i < 125)
            {
                M[i]++;
            }
        }
    }

    private static void PrintElements(int[] M)
    {
        for (int i = 0; i < M.Length; i++)
        {
            if (M[i] != 0)
            {
                Console.Write($"{i}: {M[i]}");
            }
            Console.WriteLine();
        }
    }
}

 */




