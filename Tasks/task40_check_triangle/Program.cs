/* 

Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

Подсказка - Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.

 */

Console.Clear();

System.Console.WriteLine("Введите три числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

bool Triangle(int numberA, int numberB, int numberC)
{

    if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
    {
        return true;
    }
    return false;
}

System.Console.WriteLine(Triangle(numberA, numberB, numberC));


