int[,] CreateMatrix(int lenRow, int lenColumn)
{
    int[,] newMatrix = new int[lenRow, lenColumn];
    Random random = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = random.Next(-5, 5);
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

int[,] ChangeMatrixRows(int[,] matrixToChange)
{
    int container = 0;
    for (int j = 0; j < matrixToChange.GetLength(1); j++)
    {
        container = matrixToChange[0, j];
        matrixToChange[0, j] = matrixToChange[matrixToChange.GetLength(0) - 1, j];
        matrixToChange[matrixToChange.GetLength(0) - 1, j] = container;
    }
    return matrixToChange;
}

int[,] myArray = CreateMatrix(3, 4);
PrintMatrix(myArray);
Console.WriteLine();
PrintMatrix(ChangeMatrixRows(myArray));