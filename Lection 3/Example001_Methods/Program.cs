// Вид 1:
void Method1()
{
    Console.WriteLine("Привет, мир!");
}
Method1();

// Вид 2:
void Method2(string message)
{
    Console.WriteLine(message);
}
Method2(message: "Привет, лох!");

void Method21(string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i++;
    }
}
Method21(message: "Привет, попа!", count: 3);
Method21(count: 3, message: "Привет, новая попа!");

// Вид 3:
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4:
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "лох");
// Console.WriteLine(res);

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(10, "лох");
Console.WriteLine(res);

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы дадите мне чаю?";

string  Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j]<array[minPosition]) minPosition = j;
        }
        
        int tepmporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tepmporary;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);