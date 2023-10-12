/*

Напишите программу которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
разделеные знаком табуляции.

*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine(Работает));

for(int i = 2; i <= number; i = i + 2)
{
	System.Console.Write(i + "\t");
}