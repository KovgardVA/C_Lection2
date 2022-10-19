bool FindElement(int[] collection, int find)
{
    for(int count = 0; count < collection.Length; count++)
    {
        if(collection[count] == find)
        {
            return true;
        }
    }
    return false;
}

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

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] array = FillArray(12, -9, 9);
Console.WriteLine("Наш массив:");
PrintArray(array);

int findNumber = Prompt("\nВведите число для поиска: ");
if(FindElement(array, findNumber))
{
    Console.WriteLine("Данный элемент есть в массиве!");
}
else Console.WriteLine("Данного элемента нет в массиве!");