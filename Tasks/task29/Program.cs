/*

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

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
