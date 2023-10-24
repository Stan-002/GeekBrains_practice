/* 

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/


internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Введите количество чисел (M): ");
        int M = int.Parse(Console.ReadLine());

        int positiveCount = 0;
        int[] array = new int[M];
        for (int i = 0; i < M; i++)
        {
            System.Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                positiveCount++;
            }
        }

        System.Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
    }
}
