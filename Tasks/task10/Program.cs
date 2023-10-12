/*

task(Работает)10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого 
числа.
456 -> 5
782 -> 8
918 -> 1

*/

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine(Работает));
if (number < 100 || number > 1000)
{
	Console.WriteLine("Число слишком большое");
}

else
{
int result = number / 10 % 10;
System.Console.WriteLine(result);
}



