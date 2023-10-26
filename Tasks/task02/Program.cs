/* 

Задача 2: Внутри класса Answer напишите метод CompareNumbers,
который на вход принимает два числа и выводит,
какое число большее, а какое меньшее.
a = 5; b =7 -> Первое число 5 меньше чем второе число 7
a = 3; b = 2 -> Введение числа равны 2

*/

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}