int a, fatorial = 1;

Console.Clear();
Console.WriteLine("Digite um numero: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write(a + "! = ");
for (int i = a; i >= 1; i--)
{
    Console.Write(i + " ");
    fatorial *= i;

    if (i > 1)
    {
        Console.Write(" X ");
    }
}

Console.Write("= " + fatorial);
Console.ReadLine();