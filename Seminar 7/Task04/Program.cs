int Prompt (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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

// bool FindNumber (int[,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == number)
//             {
//                 Console.WriteLine($"Позиция элемента {number} в массиве: [{i + 1}, {j + 1}]");
//                 return true;
//             }
//         }
//     }
//     return false;
// }

(int, int) Search (int[,] array, int number)
{
    int line = -1; int column = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (i, j);
            }
        }
    }
    return (line, column);
}

int[,] myArray = CreateArray(3, 4);
PrintArray(myArray);
int numberToFind = Prompt("Введите число для поиска: ");
(int line, int column) = Search (myArray, numberToFind);
if (line == -1) Console.WriteLine("Такого элемента нет!");
else Console.WriteLine($"Позиция элемента {numberToFind} в массиве: [{line + 1}, {column + 1}]");
// if (!FindNumber(myArray, numberToFind)) Console.WriteLine("Такого числа нет!");