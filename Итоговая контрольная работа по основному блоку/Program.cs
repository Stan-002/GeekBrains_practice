/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 */




using System;
using System.Collections.Generic;
using System.Linq;

/*  */
class Program
{
    static void Main()
    {
        string[] array1 = { "Hello", "2", "world", ":-)" };
        string[] array2 = { "1234", "1567", "-2", "computer science" };
        string[] array3 = { "Russia", "Denmark", "Kazan" };

        int i, count = 0;
        string[] temp = new string[100];

        for (i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                temp[count] = array1[i];
                count++;
            }
        }

        for (i = 0; i < array2.Length; i++)
        {
            if (array2[i].Length <= 3)
            {
                temp[count] = array2[i];
                count++;
            }
        }

        for (i = 0; i < array3.Length; i++)
        {
            if (array3[i].Length <= 3)
            {
                temp[count] = array3[i];
                count++;
            }
        }

        string[] result = new string[count];

        for (i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }

        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}