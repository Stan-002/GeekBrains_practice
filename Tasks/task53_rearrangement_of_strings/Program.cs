/* 

Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку 
массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2

 */



Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
void SwapFirstAndLastRow(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int tmp = arr[0, j];
            arr[0, j] = arr[rows - 1, j];
            arr[rows - 1, j] = tmp;
        }
    }

int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
SwapFirstAndLastRow(array2D);
System.Console.WriteLine();
Print2DArray(array2D);
