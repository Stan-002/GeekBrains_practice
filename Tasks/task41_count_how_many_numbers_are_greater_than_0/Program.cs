/* 

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/




System.Console.Write("Укажите количество чисел: ");
int value = int.Parse(System.Console.ReadLine());

int count = 0;

for(int i = 0; i < value; i++)
{
    System.Console.Write("Введите число: ");
    if(int.Parse(System.Console.ReadLine()) > 0 ) count++;
}

System.Console.WriteLine("Чисел со значением больше нуля было введено: " + count);




/* 

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("]");
    Console.ResetColor();
}

int userSize = Prompt("Enter array size: ");
int[] userArray = GetArray(userSize);
PrintArray(userArray);

int CountPositivDigits(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result ++;
    }
    return result;
}
int count = CountPositivDigits(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"Positive Digits > 0 = {count}");

 */

/* 

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

 */

