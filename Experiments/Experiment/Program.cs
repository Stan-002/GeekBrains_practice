void Message(string user)
{

	if (user == "Аня")
	{
		Console.WriteLine("Привет, Аннечка Милая, как ты?");
	}
	else
	{
		Console.WriteLine("О привет");
	}
}

Console.Clear();
Console.WriteLine("Введите имя пользователя: ");
string user = Console.ReadLine();
Message(user);