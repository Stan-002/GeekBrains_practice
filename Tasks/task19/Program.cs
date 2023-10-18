Console.Clear();

int UserReverse(int a)
{
	int revN = 0;
	for (int i = a; i > 0; i /= 10)
	{
		revN = revN * 10 + i % 10;
	}
	return revN;
}

void Result(int a, int b)
{
	if (a == b)
		System.Console.WriteLine("Yes");
	else
		System.Console.WriteLine("No");
}

System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int revN = UserReverse(n);

Result(n, revN);

















/*

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;
if (n >= 10000 & n <= 99999)
{
	if (n1 == n4 & n2 == n3)
	{
		System.Console.Write("Да");
	}
	else
	System.Console.WriteLine("Нет");
}
else
{
	System.Console.WriteLine("Число не пятизначное!");
}

// 123 : 10 = 12 целых (3) в остатке
// 12 : 10 = 1 целых (2) в остатке
// 7 : 2 = 3 целых (1) в остатке

*/








/*

int UserReverse(int a)
{
	int revN = 0;
	for (int i = a; i > 0; i /= 10)
	{
		revN = revN * 10 + i % 10;
	}
	return revN;
}

void Result(int a, int b)
{
	if (a == b) System.Console.WriteLine("Yes");
	else System.Console.WriteLine("No");
}

System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int revN = UserReverse(n);

Result(n, revN);

*/

/*

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i/=10)
{
	revN = revN * 10 + i % 10;
	System.Console.WriteLine();
}
if (N == revN)
System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");

 */

/*

System.Console.Write("набирите пятизначное число: ");
int val = Convert.ToInt32(Console.ReadLine());
if(val <= 99999 && val >= 10000);
{
	System.Console.WriteLine("пятизначное цифры нет");
}
int rev = 0;
while(val != 0)
{
	rev = rev * 10 + val % 10;
	val /= 10;
}
string str = rev.ToString();
Console.WriteLine($"{str[0]} {str[1]} {str[3]} {str[4]}");
if (str[0] == str[4] && str[1] == str[3])
{
	Console.WriteLine($"Евляется полидромом {str[0]} {str[1]} {str[3]} {str[4]}");
}
else
{
	Console.WriteLine("Число не палидром");
}

*/
