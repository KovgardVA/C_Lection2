int[] FillArray(int length, int minLimit, int maxLimit)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(minLimit,maxLimit + 1);
    return collection;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

void ReverseArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] *= -1;
    }
}

int[] array = FillArray(12, -9, 9);
Console.WriteLine("Наш массив:");
PrintArray(array);
ReverseArray(array);
Console.WriteLine("\nМассив с заменой:");
PrintArray(array);