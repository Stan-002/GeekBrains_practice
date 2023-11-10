/* 

Задан одномерный массив целых чисел. 
Образуйте из него два отсортированных по возрастанию массива, 
содержащих четные и нечетные числа. 
Подсказка: четное число делится на 2 без остатка.

 */

Console.Clear();


void EvenAndOdd(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.WriteLine($"{numbers[i]} - это четное число");
        }
        else
        {
            Console.WriteLine($"{numbers[i]} - это нечетное число");
        }
    }
}
int[] numbers = { 5, 2, 7, 3, 4, 6, 8, 1, 9 };
EvenAndOdd(numbers);