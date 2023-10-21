Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

void SumNegIdx(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        summ = arr[i] + summ;
    }
    System.Console.WriteLine(summ);
}

int[] array = GetRnd(5);
PrintArray(array);
System.Console.WriteLine();
SumNegIdx(array);