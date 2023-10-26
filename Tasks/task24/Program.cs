using System;
/* 

Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int Sum(int num)

{
	int result = 0;
	for (int i = 1; i <= num; i++)
	{
		result = result + i;
	}
	return result;
}

int userSum = Sum(userNum);
System.Console.WriteLine(userSum);

