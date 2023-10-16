using System.Drawing;
using System.Dynamic;
using System;

/*

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Sum(int A, int B)
{
	int result = 1;
	for (int i = 0; i < B; i++)
	{
		result *= A;
	}
	return result;
}
int result = Sum(A,B);
System.Console.WriteLine(result);