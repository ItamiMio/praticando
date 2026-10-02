using System.Net;
using System.Threading.Tasks.Dataflow;
bool continuar = true;
while (continuar)
{
    Console.Clear();
    Console.WriteLine("== Calculadora Simples ==");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1: Adição");
    Console.WriteLine("2: Subtração");
    Console.WriteLine("3: Multiplicação");
    Console.WriteLine("4: Divisão");
    Console.WriteLine("5: Sair");

    string opcao = Console.ReadLine();
    double numero1, numero2;
    double resultado = 0;
    bool operacaoValida = true;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o primeiro valor");
            double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite o segundo valor");
            double.TryParse(Console.ReadLine(), out numero2);
            resultado = numero1 + numero2;
            break;

        case "2":
            Console.WriteLine("Digite o primeiro valor");
            double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite o segundo valor");
            double.TryParse(Console.ReadLine(), out numero2);
            resultado = numero1 - numero2;
            break;

        case "3":
            Console.WriteLine("Digite o primeiro valor");
            double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite o segundo valor");
            double.TryParse(Console.ReadLine(), out numero2);
            resultado = numero1 * numero2;
            break;

        case "4":
            Console.WriteLine("Digite o primeiro valor");
            double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite o segundo valor");
            double.TryParse(Console.ReadLine(), out numero2);
            if (numero2 == 0)
            {
                Console.WriteLine("Não é possível dividir nenhum número por zero");
                operacaoValida = false;
            }
            else
                resultado = numero1 / numero2;
            break;

        case "5":
            continuar = false;
            operacaoValida = false;
            break;


        default:
            Console.WriteLine("Opção inválida!");
            operacaoValida = false;
            break;
    }

    if (operacaoValida)
    {
        Console.WriteLine($"O resultado da sua operação é: {resultado}");
        Console.WriteLine("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
    }


}


