/*

1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет

*/

Console.Clear();

System.Console.WriteLine("Введите число 1: ");
Double userNumber1 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
Double userNumber2 = Convert.ToDouble (Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}