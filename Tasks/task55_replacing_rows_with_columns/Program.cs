/* 

Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

 */

using System;
Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] ChangeRows(int[,] array)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temperary = result[0, j];
        result[0, j] = result[array.GetLength(0) - 1, j];
        result[array.GetLength(0) - 1, j] = temperary;
    }
    return result;
}

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] result = CopyArray(array);
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (i != j)
            {
                temporary = result[i, j];
                result[i, j] = result[j, i];
                result[j, i] = temporary;
            }
        }
    }
    return result;
}

int userArrayRow = TakeEnteredNumber("Введите количество строк и столбцов:");
int userArrayColumn = userArrayRow;
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);

int[,] userArray2 = ReplaceRowsColumns(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray2);

/* 

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
void SwapRowsAndColumns(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    if (rows != columns)
    {
        System.Console.WriteLine("Невозможно заменить строки на столбцы");
        return;
    }

    int[,] newArray = new int[columns, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            int tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
}



int[,] array2D = new int[3, 3];
FillArray(array2D);
Print2DArray(array2D);
SwapRowsAndColumns(array2D);
System.Console.WriteLine();
Print2DArray(array2D);

 */

 /* 
 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов массива: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 100);
            }
        }

        Console.WriteLine("\nИсходная массива:");
             
        PrintMatrix(matrix);

        if (rows == cols)
        {
            TransposeMatrix(matrix);
            Console.WriteLine("\nМассив после замены строк на столбцы:");
            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine("\nНевозможно заменить строки на столбцы для данного массива.");
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
         int rows = matrix.GetLength(0);
         int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
       
static void TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                
            {
               
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }
}
}
 
  */