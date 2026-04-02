// Crie um programa para calcular as dimensões de uma caixa retangular//
// Comprimento x Largura x Altura//
// (Formula V = C . L . A) 50cm (Comprimento) X 30cm (Largura) x 20cm (Altura)

Console.WriteLine("Digite as dimensões da caixa retangular: ");

double comprimento = Convert.ToDouble(Console.ReadLine());
double largura = Convert.ToDouble(Console.ReadLine());
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;


Console.WriteLine($"O Volume da caixa é: {volume:F2} cm3");

Console.ReadLine();