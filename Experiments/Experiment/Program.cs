using System.Dynamic;
using System;



void Message(string user)
{
	if (user == "Аня")
	{
		System.Console.WriteLine("Привет, Аннечка Милая, как ты?");
	}
	else if (user != "Аня")
	{
		System.Console.WriteLine("О привет");
	}
}

Console.Clear();
System.Console.WriteLine("Введите имя пользователя: ");
string user = Console.ReadLine();
Message(user);