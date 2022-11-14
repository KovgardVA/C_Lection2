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

(int, int) SearchMinInMatrix(int[,] matrix)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteRowNColumn(int[,] matrixToDelete)
{
    int[,] newMatrix = new int[matrixToDelete.GetLength(0) - 1, matrixToDelete.GetLength(1) - 1];
    (int lineToDelete, int columnToDelete) = SearchMinInMatrix(matrixToDelete);
    int newLine = 0;
    int newColumn = 0;
    for (int i = 0; i < matrixToDelete.GetLength(0); i++)
    {
        if (i != lineToDelete)
        {
            newColumn = 0;
            for (int j = 0; j < matrixToDelete.GetLength(1); j++)
            {
                if (j != columnToDelete)
                {
                    newMatrix[newLine, newColumn] = matrixToDelete[i,j];
                    newColumn++;
                }
            }
            newLine++;
        }
    }
    return newMatrix;
}

int[,] myMatrix = CreateMatrix(3, 4);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(DeleteRowNColumn(myMatrix));