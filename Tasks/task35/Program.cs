/* 

35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. 
В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]"); // задает следующую строку
}

void Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
            count++;
    }
    System.Console.WriteLine(count);
}

int[] arr = CreateArray(12, 0, 150);
Output(arr);
Count(arr);

/* 

using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int Change1Array(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && 99 >= array[i])
        {
            count++;
        }
    }
    return count;
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userArraySize = TakeEntNum("Please, enter array size:");
int userArrayStart = TakeEntNum("Please, enter array start number range:");
int userArrayEnd = TakeEntNum("Please, enter array end number range:");
int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
PrintArray(userArray);
System.Console.WriteLine(Change1Array(userArray));

 */

