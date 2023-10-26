/* 

Autotest(Работает)007:

Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

N = 3 
/*
1
8
27
*/

// N = 5
/*
1
8
27
64
125
*/

//  */



using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже
        for (int i = 1; i <= N; i++)
        {
            System.Console.WriteLine(Math.Pow(i, 3));
        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
