/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


Console.Clear();

int[] GetArray(int start, int end, int size)
{
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(start, end+1);
	}
	return array;
}

void PrintArray(int[] arr)
{
	Console.ForegroundColor=ConsoleColor.Green;
	System.Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		System.Console.Write(arr[i]);
		if (i < arr.Length - 1)
		System.Console.Write(", ");//[5, 7, 1, 4]
	}
	System.Console.Write("]");
	Console.ForegroundColor=ConsoleColor.Blue;
}

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);

/* 

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(200);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");//[5, 7, 1, 4]
    }
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write("]");
    Console.ResetColor();
}

*/


/* 

int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};

int[] PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	return arr;
}
PrintArray(arr);


 */

