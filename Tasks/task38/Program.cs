Console.Clear();

double[] GetDoubleRnd(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 99) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

double[] arrayDouble = GetDoubleRnd(5);
PrintDoubleArray(arrayDouble);
