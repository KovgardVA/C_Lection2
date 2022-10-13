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