Console.Clear();

System.Console.WriteLine("Введите число 1: ");
Double userNumber1 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
Double userNumber2 = Convert.ToDouble (Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

