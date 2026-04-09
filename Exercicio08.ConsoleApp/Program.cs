Console.Clear();
Console.WriteLine("Digite um numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Numero informado é par. ");
}
else
{
    Console.WriteLine("Numero informado é impar. ");
}

Console.ReadLine();