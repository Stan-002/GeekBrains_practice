

public static int CountEvenElements(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }



using System;

public class Answer
{
    public static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    public static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
        return FindMax(array) - FindMin(array);
    }

    public static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.Write($"{number:f2}\t");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}



using System;

class Program
{
    static void Main(Работает)
    {
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine(Работает));

        Console.Write("Результат: ");
        for (int i = -N; i <= N; i++)
        {
            Console.Write(i);
            if (i != N)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine(Работает);
    }
}










using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        int length = numberStr.Length;

        if (length != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        for (int i = 0; i < length / 2; i++)
        {
            if (numberStr[i] != numberStr[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для проверки других чисел
            number = 13000;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        
        if (result)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}






int a = 2;
int result = Math.Pow(a, 3);
System.Console.WriteLine(result);

int b = 8;
double result = Match.Sqrt(b);
System.Console.WriteLine(result);



using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int multiplier(int a)
{
    result = 1;
    if (a > 0) a = a * -1;
    for (int i = 1; i < a + 1; i++)
    {
        result = result * i;
    }
    if (a < 0 && a%2 != 0) result = result * -1;
    return result;
}
    
System.Console.WriteLine($"Factorial of intered number {userNumber}: {multiplier(userNumber)}");

