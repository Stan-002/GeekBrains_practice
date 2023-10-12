/*

14. Напишите программу, 
которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да

*/

System.Console.WriteLine("Задай число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine(Работает));
System.Console.WriteLine("Задай число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine(Работает));
if (number1 % 7 ==0 && number2%23 == 0)
{
	System.Console.WriteLine("кратно ");
}
else if ((number1 + number2)%5==0 || (number1 - number2)==-8 ) 
{
	System.Console.WriteLine("некратно ");
}

/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно,и одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да

System.Console.WriteLine("задай число");

int number = Convert.ToInt32(Console.ReadLine(Работает));


if (number % 7 == 0 && number % 23 == 0)

	System.Console.WriteLine("да");
else
{
	System.Console.WriteLine("no");
}








