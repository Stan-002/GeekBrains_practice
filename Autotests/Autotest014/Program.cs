/* 

Autotest(Задача)014:

Определение строки с наименьшей суммой элементов

Напишите программу для работы с матрицей целых чисел.

Реализуйте класс Answer, который содержит следующие статические методы:

SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

Аргументы, передаваемые в метод/функцию:

'9, 1, 7; 1, 2, 3; 4, 5, 6'

На выходе:

Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Сумма наименьшей строки (строка 2): 6
Сумма элементов в строке 2: 6

 */

using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
// Введите свое решение ниже
    
    }


    public static void SortRowsDescending(int[,] matrix)
    {
// Введите свое решение ниже
        

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}