﻿using System;

/*

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

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
