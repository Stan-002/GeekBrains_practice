/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = number; i >= 100; i = i / 10)
{
    result = i % 10;
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(result);
}
	

/*

Мой собственный пример

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
	
	



// Смещение разряда числа с разряда на 1 на 3
int x = 32679;
x = x << 6; // x равно 2097152

// Извлечение третьей цифры.
int thirdDigit = x % 1000 / 100;

// Вывод результата.
Console.WriteLine($"Третья цифра: {thirdDigit}");

*/










