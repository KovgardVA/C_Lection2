// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] FillArray(int length)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(0,2);
    return collection;
}

void PrintArrya(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++) Console.Write(col[position] + " ");
}

PrintArrya(FillArray(4));

// void FillandPrintArray(int length)
// {
//     int[] array = new int[length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//         Console.Write(array[i] + " ");
//     }
// }

// FillandPrintArray(8);