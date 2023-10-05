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

        Console.WriteLine(); // Перевод строки для читаемости вывода
    }
}