/* 

Задача 62: Заполните спирально массив 4 на 4.

 */


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число одной стороны: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число другой стороны: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, m];
        SpiralArray(array, n, m); 
        PrintArray(array);
    }

    static void SpiralArray(int[,] array, int n, int m)
    {
        int number = 1;
        int rowStart = 0;
        int rowEnd = n - 1;
        int colStart = 0;
        int colEnd = m - 1;

        while (number <= n * m)
        {
            // Print from left to right
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = number++;
            }
            rowStart++;

            // Print from top to bottom
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = number++;
            }
            colEnd--;

            // Print from right to left
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = number++;
            }
            rowEnd--;

            // Print from bottom to top
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = number++;
            }
            colStart++;
        }
    }

    static void PrintArray(int[,] array)
    {
        int n = array.GetLength(0);
        int m = array.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}