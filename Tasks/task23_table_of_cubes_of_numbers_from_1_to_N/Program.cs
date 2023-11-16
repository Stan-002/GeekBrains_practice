/*
Задача 23: Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
	System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}



/* 

using System;
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
	System.Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)} ");
}

*/