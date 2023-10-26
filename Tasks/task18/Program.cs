/*

Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).

*/

System.Console.WriteLine("Введите координаты точки: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());

if(userCvoter == 1)
{
	System.Console.WriteLine("Все X и Y больше 0");
}

if(userCvoter == 2)
{
	System.Console.WriteLine("Все X меньше 0, а Y больше 0");
}

if(userCvoter == 3)
{
	System.Console.WriteLine("Все X и Y меньше 0");
}

if(userCvoter == 4)
{
	System.Console.WriteLine("Все X больше 0, а Y меньше 0");
}