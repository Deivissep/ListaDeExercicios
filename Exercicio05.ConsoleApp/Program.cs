Console.Clear();
Console.WriteLine("Digite aqui o nota da primeira prova: ");
double prova1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite aqui o peso da Prova: ");
double peso1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite aqui a nota da segunda prova: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite aqui o peso da segunda nota");
double peso2 = Convert.ToDouble(Console.ReadLine());


double mediaPonderada = (prova1 * peso1 + nota2 * peso2) / (peso1 + peso2);

Console.WriteLine($"A média ponderada da nota é : {mediaPonderada:F2}");

Console.ReadLine();