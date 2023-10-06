/*

*/

System.Console.WriteLine("Задай число 1");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    System.Console.WriteLine($"Число `{number}` чётное");
}
else
{
    System.Console.WriteLine($"Число `{number}` нечётное");
}