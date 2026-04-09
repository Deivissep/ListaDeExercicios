Console.Clear();
Console.WriteLine("Digite aqui o valor de A: ");
decimal valorA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite aqui o valor de B: ");
decimal valorB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite aqui o valor de C: ");
decimal valorC = Convert.ToDecimal(Console.ReadLine());

decimal soma = valorA + valorB;

if (soma < valorC)
{
    Console.WriteLine("A Soma de A + B é menor que C");
}
else
{
    Console.WriteLine("A Soma de A + B é maior que C");
}

Console.ReadLine();