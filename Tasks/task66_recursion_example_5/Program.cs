/* 

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

 */

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(M, N);
    }
    static void PrintNumbers(int M, int N)
    {
        int sum = 0;
        for (int current = M; current <= N; current++)
        {
            sum += current;
        }
        Console.WriteLine("Сумма натуральных элементов в промежутке от " + M + " до " + N + " равна: " + sum);
    }
}

















/* 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        int sum = 0;
        for (int current = M; current <= N; current++)
        {
            if (current % 2 == 0) 
            {
                sum += current;
            }
        }
        Console.WriteLine("Сумма натуральных элементов в промежутке от " + M + " до " + N + " равна: " + sum);
    }
}

 */

/* 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int current = M; current <= N; current++)
        {
            sum += current;
        }

        Console.WriteLine("Сумма натуральных элементов в промежутке от " + M + " до " + N + " равна: " + sum);
    }
}

 */