using System;

public class Program
{
    public static int[,] IntroArray(int right, int left)
    {
        int[,] array = new int[right, left];
        int result = 1;
        
        for (int i = 0; i < right; i++)
        {
            for (int j = 0; j < left; j++)
            {
                array[i, j] = result;
                result++;
            }
        }
        return array;
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Введите право: ");
        int IntroRight = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите лево: ");
        int IntroLeft = Convert.ToInt32(Console.ReadLine());
        
        int[,] user2DArray = IntroArray(IntroRight, IntroLeft);

        // Выводим двумерный массив на консоль
        for (int i = 0; i < IntroRight; i++)
        {
            for (int j = 0; j < IntroLeft; j++)
            {
                Console.Write(user2DArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
