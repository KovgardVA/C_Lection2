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

void PrintMatrix(int[,] array)
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

int[,] ChangeRowsNColumnsInMatrix(int[,] matrixToChange)
{
    int container = 0;
    for (int i = 0; i < matrixToChange.GetLength(0); i++)
    {
        for (int j = i; j < matrixToChange.GetLength(1); j++)
        {
            if (i != j)
            {
                container = matrixToChange[i,j];
                matrixToChange[i,j] = matrixToChange[j,i];
                matrixToChange[j,i] = container;
            }
        }
    }
    return matrixToChange;
}

int[,] myArray = CreateArray(3, 3);
PrintMatrix(myArray);
Console.WriteLine();
PrintMatrix(ChangeRowsNColumnsInMatrix(myArray));