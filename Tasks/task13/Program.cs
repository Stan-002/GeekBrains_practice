/*

task13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 / 10)
{
	Console.WriteLine(number % 10);
}
	
if (number < 100)
{
	Console.WriteLine("Третьей цифры нет");
}
	
	
	

		
	


/*

мой собственный пример

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 / 10)
{
	Console.WriteLine(number % 10);
}
	
if (number < 100)
{
	Console.WriteLine("Третьей цифры нет");
}

гибриды

System.Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int length = Number.ToString().Length;

if (length < 3)
{
	System.Console.WriteLine("Число не содержит третьей цифры");
}
else
{
	int result = Number / 100 % 10;
	System.Console.WriteLine(result);
}



System.Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 999)
{
	int result = Number / 100 % 10;
	System.Console.WriteLine(result);
}
else if (Number > 100)
{
	System.Console.WriteLine("Третьей цифры нет");
}
else
{
	System.Console.WriteLine("Число должно быть больше 100");
}


*/










