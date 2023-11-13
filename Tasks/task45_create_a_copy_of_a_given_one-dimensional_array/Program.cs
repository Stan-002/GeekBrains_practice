/* 

Задача 45: Напишите программу, 
которая будет создавать копию заданного одномерного массива 
с помощью поэлементного копирования.

*/

Console.Clear();

int[] GetRandArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.Write(" ");
}

System.Console.Write("Ввести размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArray);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("-> ");

int[] CopyArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
PrintArray(CopyArray(userArray));

/* 

using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number}\t");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}
2
using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum += array[i];
        }
        return sum;
    }

    public static void PrintArray(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
        if (i < array.Length - 1) // Проверяем, не последний ли элемент
        {
        Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
        }
      }
        Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем массив по умолчанию
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}

3
using System;

public class Answer
{
    public static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    public static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
        return FindMax(array) - FindMin(array);
    }

    public static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.Write($"{number:f2}\t");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}

 */