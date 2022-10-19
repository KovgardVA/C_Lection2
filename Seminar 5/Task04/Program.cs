int[] FillArray(int length)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(-200,200);
    return collection;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int CountOf(int[] randomArray, int minLimit, int maxLimit)
{
    int count = 0;
    for(int index = 0; index < randomArray.Length; index++)
    {
        if (randomArray[index] >= minLimit && randomArray[index] <= maxLimit)
        {
            count++;
        }
    }
    return count;
}

int[] array = FillArray(12);
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine($"\nКоличество подходящих элементов: {CountOf(array, 10, 99)}");