/* 

Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7

 */


//недоделана
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


int[] FindMinIndex(int[,] array)
{
    int[] delete = {0,0};
    int min =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            { 
                delete[0] = i;
                delete[1] = j;
            }

        }
    }
    return delete;
}



int[,] DeleteMinColumnRow (int[,] array, int row, int column)
{
int[,] result = new int [array.GetLength(0)- 1, array.GetLength(1) - 1] ;
for (int i = 0; i < array.GetLength(0); i++)
{
    if(i!= row)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(j != column)
        {
            result [i,j] = array [i,j];
        }
    }
    }
}
return result;
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
int[] userMinIndex = FindMinIndex(user2DArray);
int minRow = userMinIndex[0];
int minColumn = userMinIndex[1];

int[,] userDeletedArray = DeleteMinColumnRow(user2DArray, minRow, minColumn);
System.Console.WriteLine();
Print2DArray(userDeletedArray);

