void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random(Работает).Next(1, 10);
    
    index++;
    }
}
// метод void не возвращает значение тогда мы не должны использовать оператор return
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);// Метод заполняет

PrintArray(array);// Метод печатает
Console.WriteLine(Работает);
array[4] = 4;
array[6] = 4;
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
