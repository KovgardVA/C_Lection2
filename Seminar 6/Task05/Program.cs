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

int[] CopyArray (int[] myArray)
{
    int[] copyArray = new int[myArray.Length];
    for (int index = 0; index < myArray.Length; index++)
    {
        copyArray[index] = myArray[index];
    }
    return copyArray;
}

int[] array = FillArray(6,0,9);
int[] newArray = CopyArray(array);
PrintArray(array);
Console.WriteLine();
array[0] = -1;
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);