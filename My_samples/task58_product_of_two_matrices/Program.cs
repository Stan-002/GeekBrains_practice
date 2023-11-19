/* 

Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.

 */


using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Введите количество строк первой матрицы: ");
        int rows1 = GetNumberFromUserInput();

        Console.Write("Введите количество столбцов первой матрицы: ");
        int columns1 = GetNumberFromUserInput();

        int[,] matrix1 = new int[rows1, columns1];
        Console.WriteLine("Введите элементы первой матрицы:");
        ReadMatrix(matrix1);

        Console.Write("Введите количество строк второй матрицы: ");
        int rows2 = GetNumberFromUserInput();

        Console.Write("Введите количество столбцов второй матрицы: ");
        int columns2 = GetNumberFromUserInput();

        int[,] matrix2 = new int[rows2, columns2];
        Console.WriteLine("Введите элементы второй матрицы:");
        ReadMatrix(matrix2);

        try
        {
            int[,] result = MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("Результат умножения матриц:");
            PrintMatrix(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    private static int GetNumberFromUserInput()
    {
        int number;
        while (true)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Пожалуйста, введите число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число находится вне допустимого диапазона для типа int. Пожалуйста, введите число в пределах от " + int.MinValue + " до " + int.MaxValue + ".");
            }
        }

        return number;
    }

    private static int[,] MultiplyMatrices(int[,] rows, int[,] columns)
    {
        int rowCount1 = rows.GetLength(0);
        int colCount1 = rows.GetLength(1);
        int rowCount2 = columns.GetLength(0);
        int colCount2 = columns.GetLength(1);

        if (colCount1 != rowCount2)
        {
            throw new Exception("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
        }

        int[,] result = new int[rowCount1, colCount2];

        for (int i = 0; i < rowCount1; i++)
        {
            for (int j = 0; j < colCount2; j++)
            {
                for (int k = 0; k < colCount1; k++)
                {
                    result[i, j] += rows[i, k] * columns[k, j];
                }
            }
        }

        return result;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    private static void ReadMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write("matrix[" + i + "," + j + "]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}