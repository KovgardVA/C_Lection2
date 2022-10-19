int[] FillArray(int length)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(0,10);
    return collection;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int[] SumOfPairs(int[] array)
{
    int[] pairsum;
    if (array.Length % 2 == 0)
    {
        pairsum = new int[array.Length / 2];
    }
    else 
    {
        pairsum = new int[array.Length / 2 + 1];
    }

    for (int i = 0; i < array.Length / 2; i++)
    {
        pairsum[i] = array[i] + array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        pairsum[pairsum.Length - 1] = array[pairsum.Length-1];
    }
    return pairsum;
}

int[] array = FillArray(5);
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine();
PrintArray(SumOfPairs(array));