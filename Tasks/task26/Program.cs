using System;

/*

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Result(int number)
{
	int count = 0;
	for (int i = number; i > 0; i /= 10)
	{
		count++;
	}
	return count;
}
int userCount = Result(userNum);
System.Console.WriteLine(userCount);
