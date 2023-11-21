/* 

Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.

 */





//Недоделана
internal class Array2D
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер строки. i: ");
        int low = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер столбца. j: ");
        int high = Convert.ToInt32(Console.ReadLine());

        int[][] arr1 = new int[low][];
        int[][] arr2 = new int[high][];



        QuickSort(arr1, 0, arr1.Length - 1);//Здесь
        QuickSort(arr2, 0, arr2.Length - 1);



        static void QuickSort(int[][] array, int low, int high)
        {

            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);//Здесь

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }


            static void Swap(int[][] array, int index1, int index2)
            {
                int[] temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
            static int Partition(int[][] array, int low, int high)
            {
                int[] pivot = array[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (CompareArrays(array[j], pivot) > 0)//Здесь
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                Swap(array, i + 1, high);
                return i + 1;
            }
            static int CompareArrays(int[] arr1, int[] arr2)
            {
                if (arr1.Length < arr2.Length)//Здесь
                {
                    return -1;
                }
                else if (arr1.Length > arr2.Length)
                {
                    return 1;
                }
                else
                {
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] < arr2[i])
                        {
                            return -1;
                        }
                        else if (arr1[i] > arr2[i])
                        {
                            return 1;
                        }
                    }
                    return 0;
                }
            }
        }
    }
}