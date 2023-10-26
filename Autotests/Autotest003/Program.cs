/* 

Autotest(Работает)003:

Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

Пример использования:
На входе:

number: '6'

На выходе:

Число `6` чётное

На входе:

number: '3'

На выходе:

Число `3` нечётное

 */


 
 using System;
 
class Answer
{
    static void CheckIfEven(int number)
    {
        // Введите свое решение ниже
        if (number % 2 == 0)
        {
            System.Console.WriteLine($"Число `{number}` чётное");
        }
        else
        {
            System.Console.WriteLine($"Число `{number}` нечётное");
        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}
