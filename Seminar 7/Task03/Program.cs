int[,] CreateArray(int lenRow, int lenColumn)
{
    int[,] array = new int[lenRow, lenColumn];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 5);
        }
    }
    return array;
}

int SumDiagonal (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateArray(4, 4);
PrintArray(myArray);
Console.WriteLine();
int summa = SumDiagonal(myArray);
Console.WriteLine("Сумма элементов на диагонали: " + summa);