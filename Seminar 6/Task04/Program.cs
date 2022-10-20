// f(1) = 1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)
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

int[] Fibonacci (int n)
{
    int[] fibonacci = new int[n];
    fibonacci[1] = 1;
    fibonacci[2] = 1;
    for(int i = 3; i < n; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}

int fib = Prompt("Введите число Фибоначчи: ");
Console.WriteLine();
PrintArray(Fibonacci(fib));