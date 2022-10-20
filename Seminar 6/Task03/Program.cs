int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}


int[] Binary (int num)
{
    int length = 0;
    int power = num;
    while (power > 0)
    {
        power /= 2;
        length++;
    }
    
    int[] binary = new int[length];
    int count = length - 1;
    while(num > 0)
    {
        binary[count] = num % 2;
        num /= 2;
        count--;
    }
    return binary;
}

int number = Prompt("Введите число для перевод в двоичную систему: ");
PrintArray(Binary(number));