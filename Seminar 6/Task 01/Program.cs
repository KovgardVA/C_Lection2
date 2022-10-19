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

// int[] ReverseArray (int[] myArray)
// {
//     int[] reverseArray = new int[myArray.Length];
//     for (int index = 0; index < myArray.Length; index++)
//     {
//         reverseArray[index] = myArray[myArray.Length - 1 - index];
//     }
//     return reverseArray;
// }

int[] ReverseArray (int[] myArray)
{
    int temp = 0;
    for (int index = 0; index < myArray.Length / 2; index++)
    {
        temp = myArray[index];
        myArray[index] = myArray[myArray.Length - 1 - index];
        myArray[myArray.Length - 1 - index] = temp;
    }
    return myArray;
}

int[] array = FillArray(5, 0, 9);
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine();
PrintArray(ReverseArray(array));