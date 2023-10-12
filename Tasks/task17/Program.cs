/*

Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4
x=2; y=4-> 1
x=-34; y=-30 -> 3

*/

System.Console.WriteLine("Введите координаты точки. Х: ");
int userX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки. Y: ");
int userY = Convert.ToInt32(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine("точка находится в первой четверти");
}
if (userX < 0 && userY > 0)
{
    System.Console.WriteLine("точка находится во второй четверти");
}
if (userX < 0 && userY < 0)
{
    System.Console.WriteLine("точка находится в третьей четверти");
}
if (userX > 0 && userY < 0)
{
    System.Console.WriteLine("точка находится в четвертой четверти");
}
if (userX == 0 || userY == 0)
{
    System.Console.WriteLine("точка находится на оси координат");
}
