int[] FillArray(int length, int minLimit, int maxLimit)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(minLimit,maxLimit + 1);
    return collection;
}

int Sum (int[] array, int fl = 1) // Добавляем флаг. По умолчанию 1, если параметр не был передан.
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if (array[index] * fl > 0) // Положительные станут отрицательными, отрицательные положительными при fl = -1.
        {
            sum += array[index];
        }
    }
    return sum;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int[] array = FillArray(12, -9, 9); // Вводим длину массива, минимальное и максимальное значение чисел в массиве.
Console.WriteLine("Наш массив:");
PrintArray(array);
int sumPositive = Sum(array);
int sumNegative = Sum(array, -1);
Console.WriteLine($"\nСумма отрицательных чисел: {sumNegative}");
Console.WriteLine($"Сумма положительных чисел: {sumPositive}");