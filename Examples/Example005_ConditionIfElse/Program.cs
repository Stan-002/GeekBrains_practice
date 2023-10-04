Console.Write("Введите имя пользователя: ");
string username  = Console.ReadLine();

if (username.ToLower() == "аня")
{
    Console.WriteLine("Ура, это же АНЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}