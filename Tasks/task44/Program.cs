/* 

44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/

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