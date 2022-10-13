int[] array = new int[5];
int index = 0, sum = 0;

Console.WriteLine("Введите пять чисел:");
while(index < array.Length)
{
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

for (index = 0; index < array.Length; index++)
{
    sum = sum + array[index];
}

double middle = sum / array.Length;

Console.WriteLine("Сумма: " + sum + " | Среднее: " + sum / array.Length);