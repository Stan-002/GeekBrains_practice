/* 

Задача 62: Заполните спирально массив 4 на 4.

 */


using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[][] result = SpiralArray(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] SpiralArray(int n)
        {
            
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
                result[i] = new int[n];

            int currentNumber = 1;
            int left = 0, right = n - 1, top = 0, bottom = n - 1;

            while (true)
            {
                
                for (int i = left; i <= right; i++)
                {
                    result[top][i] = currentNumber++;
                }
                top++;
                if (top > bottom || left > right) break;

                // Going down
                for (int i = top; i <= bottom; i++)
                {
                    result[i][right] = currentNumber++;
                }
                right--;
                if (top > bottom || left > right) break;

                // Going left
                for (int i = right; i >= left; i--)
                {
                    result[bottom][i] = currentNumber++;
                }
                bottom--;
                if (top > bottom || left > right) break;

                // Going up
                for (int i = bottom; i >= top; i--)
                {
                    result[i][left] = currentNumber++;
                }
                left++;
                if (top > bottom || left > right) break;
            }
            return result;
        }
    }
}