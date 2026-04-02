/*
2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
O programa deve solicitar ao usuário:
a. A quilometragem inicial do veículo no início da viagem.
b. A quilometragem final ao término da viagem.
c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.WriteLine("Digite a Distância da Viagem e a quantidade de Combustivel: ");

double quilometragemInicial = Convert.ToDouble(Console.ReadLine());
double quilometragemFinal = Convert.ToDouble(Console.ReadLine());
double quantidadeCombustivel = Convert.ToDouble(Console.ReadLine());

double combustivelGasto = quilometragemInicial + quilometragemFinal / quantidadeCombustivel;

Console.WriteLine($"A quantidade de combustivel consumida é: {combustivelGasto:F2} ");

Console.ReadLine();