/*
2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
O programa deve solicitar ao usuário:
a. A quilometragem inicial do veículo no início da viagem.
b. A quilometragem final ao término da viagem.
c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.WriteLine("Digite a Distância da Viagem e a quantidade de Combustivel: ");

Console.WriteLine("Digite o KM Inicial");
double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o KM Final");
double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantida de gasolina abastecida");
double quantidadeCombustivel = Convert.ToDouble(Console.ReadLine());

double totalQuilometragem = quilometragemFinal - quilometragemInicial;
double combustivelGasto = totalQuilometragem / quantidadeCombustivel;

Console.WriteLine($"A quantidade de combustivel consumida é: {combustivelGasto:F2} KM/L");

Console.ReadLine();