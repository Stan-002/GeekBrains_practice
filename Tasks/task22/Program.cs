using System.Text.RegularExpressions;
using Internal;
/*

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4

*/
using System;
System.Console.Write("Введи число: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
	System.Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
}

/* 

System.Console.WriteLine("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
	System.Console.WriteLine(Math.Pow(i, 2) + " ");
}

*/