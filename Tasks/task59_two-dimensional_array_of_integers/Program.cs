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


Console.Clear();


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
int[] MinElement(int[,] array)
{
    int min = array[0, 0];
    int[] arrInd = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {

                min = array[i, j];
                arrInd[0] = i; arrInd[1] = j;
            }
        }
    }
    return arrInd;
}

int[,] DeletedRowsColumns(int[,] array)
{
    int[] indArr = MinElement(array);
    int minInRow = indArr[0];
    int minInCol = indArr[1];
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newInRow = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i !=minInRow )
        {
            int newInCol = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minInCol)
                {
                    newArray[newInRow, newInCol] = array[i, j];
                    newInCol++;
                }

            }
            newInRow++;
            newInCol = 0;
        }
    }
    return newArray;
}

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

Print2DArray(array);
System.Console.WriteLine();

System.Console.WriteLine();
int[,] newArr = DeletedRowsColumns(array);
Print2DArray(newArr);