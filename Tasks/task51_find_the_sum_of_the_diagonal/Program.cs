/* 

Задача 51: Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали (с индексами 
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

 */

Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = new Random(). Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j]+ "\t");
           
        }
        System.Console.WriteLine();  
    }
}
int SumIndx(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,i]; 
    }
    return sum;
}

System.Console.WriteLine("Введите кол-во строк: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-то столбцов: ");
int userStlb = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg, userStlb);
PrintArray(userArray);
int userSum = SumIndx(userArray);
System.Console.WriteLine(userSum);


/* 

Console.Clear();
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void Dioganal(int[,] newArr)
{
    int sum = 0;
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i == j ) sum += newArr[i, j];
        }
    }
    System.Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
}

int[,] array2D = new int[3, 4];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
Dioganal(array2D);

 */