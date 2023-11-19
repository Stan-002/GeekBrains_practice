/* 

Доп. Задача 02: Задан генератором случайных чисел одномерный массив из действительных чисел. 
Найдите максимальное и минимальное число этого массива.

 */


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = CreateArray(10, 1, 100);

        int min = array.Min();
        int max = array.Max();

        Console.WriteLine("Минимальное число массива: " + min);
        Console.WriteLine("Максимальное число массива: " + max);
    }

    static int[] CreateArray(int size, int min, int max)
    {
        var random = new Random();

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }
}