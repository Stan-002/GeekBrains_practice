/* 

Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.

 */

/* Этот класс создает трехмерный массив и заполняет его числами на основе ввода пользователя. */




internal class Three_dimensional_array
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число. i: ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число. j: ");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число. k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int[,,] array3D = CountArray3D(i, j, k);

        Console.WriteLine("Elements of 3D array:");

        foreach (int item in array3D)
        {
            Console.WriteLine(item);
        }
    }

    private static int[,,] CountArray3D(int i, int j, int k)
    {
        int[,,] array3D = new int[i, j, k];

        for (int counter = 0; counter < i * j * k; counter++)
        {
            array3D[counter % i, (counter / i) % j, counter / (i * j)] = counter + 1;
        }
        return array3D;
    }
}


/* 



internal class Three_dimensional_array
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Elements of 3D array:");

        int[,,] array3D = CountArray3D();

        foreach (int item in array3D)
        {
            Console.WriteLine(item);
        }
    }

    private static int[,,] CountArray3D()
    {
        int[,,] array3D = new int[10, 10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    array3D[i, j, k] = i * 100 + j * 10 + k;
                }
            }
        }
        return array3D;
    }
}

 */