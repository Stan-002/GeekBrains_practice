/* 

Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.

 */


using System;

class Array2D
{
    static void Main()
    {
        Console.WriteLine("Введите размер строки. i: ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер столбца. j: ");
        int j = Convert.ToInt32(Console.ReadLine());
        int[][] arr1 = CreateAndFullArr(i, j, 0, 10);
}
    public static int[][] CreateAndFullArr(int row, int col, int startArray, int endArray)
    {
        int[][] array = new int[row][];
        Random rd = new Random();
        for (int i = 0; i < row; i++)
        {
            array[i] = new int[col];
            Console.Write("[");
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = rd.Next(startArray, endArray);
                Console.Write(" " + array[i][j]);
            }
            Console.WriteLine(" ]");


        }
        return array;
    }
}