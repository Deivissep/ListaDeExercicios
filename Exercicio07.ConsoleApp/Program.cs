Console.Clear();
Console.WriteLine("Digite aqui o seu peso em KG: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite aqui a sua altura em metros: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal imc = peso / (altura * altura);

Console.WriteLine($"Seu IMC é: {imc:F2}");

if (imc < 18.5m)
{
    Console.WriteLine("Você está abaixo do peso");
}
else if (imc < 25m)
{
    Console.WriteLine("Você está com o peso normal");
}
else if (imc < 30m)
{
    Console.WriteLine("Você está acima do peso");
}
else
{
    Console.WriteLine("Você está obeso");
}

Console.ReadLine();