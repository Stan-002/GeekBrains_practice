using System.Dynamic;
using System;

Console.Clear();
System.Console.WriteLine("Введите имя пользователя: ");
string user = Console.ReadLine();

// string user = "Аня";
if (user.ToLower() == "Аня")
{
	System.Console.WriteLine("Привет, Аннечка Милая, как ты?");
}
else
{
	System.Console.WriteLine("О Привет");
}
