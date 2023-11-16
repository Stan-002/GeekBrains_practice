/* 

Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

 */

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int intN(int n1, int n2)
{
    if (n2 == 1) return n1;
    else
    return n1 * intN(n1, n2 -1);
}

int result = intN(number1, number2);
System.Console.WriteLine(result);