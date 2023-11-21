/* 

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = PrintNumbers(A, B);
        Console.WriteLine("Результат: " + result);
    }

    static int PrintNumbers(int A, int B)
    {
        if (B == 0)
        {
            return 1;
        }
        else
        {
            return A * PrintNumbers(A, B - 1);
        }
    }
}