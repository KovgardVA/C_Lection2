int numero = new Random().Next(10,10000);
Console.WriteLine("Ваше число: " + numero);

int maxNumero = numero % 10;
numero = numero / 10;

while (numero > 0)
{
    if (numero % 10 > maxNumero)
    {
        maxNumero = numero % 10;
    }
    numero = numero / 10;
}

Console.WriteLine("Максимальная цифра: " + maxNumero);