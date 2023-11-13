/* 

Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/



int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonacci(int number)
{
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N = " + arrayOne.Length + ": ");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}
int number = Prompt("Enter number: ");
PrintArray(Fibonacci(number));



/*

//100% Решение Тима
public class Program044
{
    public static void Main(string[] args)
    {
        int N = 7;
        FibonacciNumbers(N);
    }
    private static void FibonacciNumbers(int number)
    {
        int[] arr = new int[number];
        int firstElement = 0;
        int secondElement = 1;
        for (int i = 0; i < number; i++)
        {
            if (i < 2)
            {
                arr[i] = i;
            }
            else
            {
                arr[i] = arr[firstElement] + arr[secondElement];
                firstElement++;
                secondElement++;
            }
            System.Console.Write($"{arr[i]} ");
        }
    }
}

*/

/* 

100% Решение Радика
using System;
Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = TakeEnteredNumber("Enter number: ");

string FebonchiNumber(int a)
{
    string result = "";
    int summ = 0;
    if(a == 0) result = result + "0";
    if(a == 1) result = result + "0 1";
    if (a > 1)
    {
        for (int i = 0; i <= a; i++)
        {
            result = result + i;    
        }
    }
    return result;

}

System.Console.WriteLine(FebonchiNumber(userNumber));

*/

/* 

//Элина Низамутдинова
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
    int result= 0;
    int ten = 1;
    while(number>0){
        result=number%2*ten+result;
        number=number/2;
        ten=ten*10;
    }
return result;
}
int Number = ToBinary(number);
Console.Write(Number);

*/

/* 

//80% 
Console.Write("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Пожалуйста, введите положительное число.");
    return;
}

int first = 0;
int second = 1;

Console.Write("Первые " + N + " чисел Фибоначчи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}

Console.WriteLine();

*/