/* 

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120

*/
Console.Clear();

int Number(int n)
{
	int num = 1;

	for (int i = 1; i <= n;  i++)
	{
		 num = num * i;
	}
	return num;
}
System.Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
int userResult = Number(userN);
System.Console.WriteLine(userResult);