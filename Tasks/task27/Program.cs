using System;

/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/




/* 

System.Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int Sum(int A)
{
	int B = 0;
	while (A > 0)
	{
		B = B + A % 10;
		A = A / 10;
	}
	return B;
}
int B = Sum(A);
System.Console.WriteLine(B);

 */






Console.Clear();

int SumNumber(int a)
{
	int result = 0;
	for (int i = a; i > 0; i/=10)
	{
		result = result + i % 10;
	}
	return result;
}

System.Console.WriteLine("Задай число");
int num = Convert.ToInt32(Console.ReadLine());
int userRes = SumNumber(num);
System.Console.WriteLine(userRes);

