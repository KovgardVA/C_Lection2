int[,] CreateMatrix(int lenRow, int lenColumn)
{
    int[,] newMatrix = new int[lenRow, lenColumn];
    Random random = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = random.Next(0, 10);
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            Console.Write($"{matrixToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int[] FrequencyDictionary(int[,] matrix)
{
    int[] dict = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            dict[matrix[i,j]]++;
        }
    }
    return dict;
}

int[,] myMatrix = CreateMatrix(3, 4);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintArray(FrequencyDictionary(myMatrix));