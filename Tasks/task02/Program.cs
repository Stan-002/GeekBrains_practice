/* 

Внутри класса Answer напишите метод CompareNumbers,
который на вход принимает два числа и выводит,
какое число большее, а какое меньшее.
a = 5; b =7 -> Первое число 5 меньше чем второе число 7
a = 3; b = 2 -> Введение числа равны 2

*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Результат: ");
        for (int i = -N; i <= N; i++)
        {
            Console.Write(i);
            if (i != N)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}