/*
Crie um programa para calcular o salário total de um vendedor.
Deverá ser informado o salário base e o total de vendas.
A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
*/

string[] funcionarios = new string[100];
int historicoComissoes = 0;

while (true == true)

{
    Console.Clear();

    Console.WriteLine("Digite 1 Para Realizar o Calculo de Comissão");
    Console.WriteLine("Digite 2 Para Consultar o Histórico de Calculo");
    Console.WriteLine("Digite S -Sair");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }


    if (opcao != "1" && opcao != "2")
    {

        Console.ReadLine();
        continue;
    }

    else if (opcao == "2")
    {
        for (int i = 0; i < historicoComissoes; i++)
        {
            Console.WriteLine(funcionarios[i]);
        }
        Console.ReadLine();
        continue;
    }


    Console.WriteLine("Digite o nome do Colaborador: ");
    string trabalhador = Console.ReadLine();



    Console.WriteLine("Digite o salário do colaborador: " + trabalhador);
    double salarioTotal = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o total de vendas do mês do colaborador");
    double vendasTotal = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o percentual que será utilizado para calcular o salário + comissão");
    double percentual = Convert.ToDouble(Console.ReadLine());

    double comissao = (percentual / 100) * vendasTotal;
    double salarioFinal = salarioTotal + comissao;


    Console.WriteLine($"O salário total do colaborador: R${salarioFinal:F2}");

    string registro = $"Nome: {trabalhador} | Total: R$ {salarioFinal:F2}";
    funcionarios[historicoComissoes] = registro;
    historicoComissoes++;

    Console.Write("Pressione ENTER para realizar calculo para outro funcionário");

    Console.ReadLine();
}

