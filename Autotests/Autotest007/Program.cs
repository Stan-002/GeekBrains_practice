using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже
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
