/* 

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 */


Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void CrossLine(double b1, double k1, double b2, double k2)
{

    if (k1 == k2)
    {
        if (b1 == b2)
            System.Console.WriteLine("Прямые совпадают");
        else
            System.Console.WriteLine("Прямые параллельны");
            return;
    }
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Две прямые пересекаются в точке с координатами X: {x}, Y: {y}");
}
CrossLine(b1, k1, b2, k2);


/*  

Console.Clear();

System.Console.WriteLine("Введите значения переменных: ");
double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());

(double x, double y) FindIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

(double x, double y) result = FindIntersection(b1, k1, b2, k2);

System.Console.WriteLine($"Найдена точка пересечения двух прямых -> x: {result.x}, y: {result.y}");


*/

/* 

if (k1 == k2)
    {
        if (b1 == b2)
            System.Console.WriteLine("Прямые совпадают");
        else
            System.Console.WriteLine("Прямые параллельны");
            return;

 */