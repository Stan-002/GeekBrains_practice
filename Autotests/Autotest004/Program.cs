using System;

public class Answer
{
	static void PrintEvenNumbers(int number)
	{
		// Введите свое решение ниже
		for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
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
		PrintEvenNumbers(number);
	}
}
