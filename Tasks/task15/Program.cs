/* 

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день!");
}
if (dayNumber == 6 || dayNumber == 7)
{
    System.Console.WriteLine("Ура выходной!");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    System.Console.WriteLine("Ошибка");
}

/*

Мое собственное решение

System.Console.WriteLine("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine(Работает));
bool isWeekend = day == 6 || day == 7;

if (day == 1)
{
	Console.WriteLine("Понедельник");
}

if (day == 2)
{
	Console.WriteLine("Вторник");
}

if (day == 3)
{
	Console.WriteLine("Среда");
}

if (day == 4)
{
	Console.WriteLine("Четверг");
}

if (day == 5)
{
	Console.WriteLine("Пятница");
}

if (day == 6)
{
	Console.WriteLine("Суббота");
}

if (day == 7)
{
	Console.WriteLine("Воскресенье");
}

if(isWeekend)
{
	Console.WriteLine("Да");
}
else
{
	Console.WriteLine("Нет");
}

*/









