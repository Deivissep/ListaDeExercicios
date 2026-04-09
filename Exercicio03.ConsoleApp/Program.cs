//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

/*
Para converter Celsius  para Fahrenheit, utilize a fórmula: F = (C x 1,8) + 32)
Multiplique a temperatura em Celsius por  1,8 (ou 9/5) e e some 32 ao resultado.
*/

double Fahrenheit = 1.8;

Console.WriteLine("Digite a temperatura que deseja converter");
double tempCelsius = Convert.ToDouble(Console.ReadLine());

double valorFinal = tempCelsius * Fahrenheit;
double temperaturaFinal = valorFinal + 32;


Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaFinal} °F");

Console.ReadLine();