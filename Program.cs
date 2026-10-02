using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exercicio = true;
        while (exercicio)
        {
            Console.Clear();
            Console.WriteLine("1: Exercício Sequência Centena");
            Console.WriteLine("2: Exercício Sequência de Pares");
            Console.WriteLine("3: Exercício Sequência em Limite");
            Console.WriteLine("4: Exercício Tabuada");
            Console.WriteLine("5: Exercício Média Decimal");
            Console.WriteLine("6: Música dos Patinhos");
            Console.WriteLine("7: Música dos Elefantes");
            Console.WriteLine("8: Desenhar um Retângulo");
            Console.WriteLine("9: Desenhar um Retângulo 2");
            Console.WriteLine("10: Calcular o fatorial de um número");
            Console.WriteLine("11: Exercício de Fibonacci");
            Console.WriteLine("0: Sair");

            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                if (opcao != 0)
                    SelecionarExercicio(opcao);
                else
                {
                    Console.WriteLine("Vlw falou");
                    exercicio = false;
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida!");
            }

            Console.WriteLine("\n\nDigite uma tecla para continuar");
            Console.ReadKey();
        }
    }

    private static void SelecionarExercicio(int opcao)
    {
        switch (opcao)
        {
            case 1:
                ExercicioSequenciaCentena();
                break;
            case 2:
                ExercicioSequenciaPares();
                break;
            case 3:
                ExercicioSequenciaLimites();
                break;
            case 4:
                ExercicioTabuada();
                break;
            case 5:
                ExercicioMediaDecimal();
                break;
            case 6:
                Musica5Patinhos();
                break;
            case 7:
                MusicaDosElefantes();
                break;
            case 8:
                RetPreenchido();
                break;
            case 9:
                RetContorno();
                break;
            case 10:
                ExercicioFatorial();
                break;
            case 11:
                ExercicioFibonacci();
                break;
            default:
                break;
        }
    }

    public static void ExercicioSequenciaCentena()
    {
        for (int contador = 1; contador <= 100; contador++)
        {
            Console.Write($"{contador.ToString()} ");
        }

        //Completo!

    }

    public static void ExercicioSequenciaPares()
    {
        uint numero = 0;
        bool econtrouPar = false;
        try
        {
            Console.Write("Digite um número inteiro positivo, por favor :) : ");
            numero = Convert.ToUInt32(Console.ReadLine());
            Console.Write($"Os números pares entre 0 e {numero} são: ");
            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i.ToString()} ");
                    econtrouPar = true;
                }
                else
                    econtrouPar = false;
            }
        }
        catch
        {
            Console.WriteLine("Número inválido T-T");
        }

        //Completo!   
    }

    public static void ExercicioSequenciaLimites()
    {
        Console.WriteLine("Digite dois números inteiros :D (o segundo número precisa ser maior que o primeiro)");
        Console.Write("Primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 < num1)
        {
            Console.WriteLine("Erro x.x");
        }
        else
        {
            for (int i = 0; i <= num2; i++)
            {
                Console.Write($"{i.ToString()} ");
            }
        }

        //Completo!
    }

    public static void ExercicioTabuada()
    {
        Console.Write("Digite um número inteiro para exibir sua tabuada UwU : ");
        bool numeroValido = false;
        while (!numeroValido)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint numero))
            {
                Console.WriteLine("Não pode ser um número negativo ò.ó");
                Console.Write("Digite o número novamente: ");
            }
            else
            {
                numeroValido = true;
                Console.WriteLine($"\nTabuada do {numero}:");
                for (uint contador = 1; contador <= 10; contador++)
                {
                    uint resultado = numero * contador;
                    Console.WriteLine($"{numero} x {contador} = {resultado}");
                }
            }

            // Completo!
        }
    }

    public static void ExercicioMediaDecimal()
    {
        Console.Write("Digite a quantidade 'u': ");
        uint quantidade = 0;
        bool quantidadeValida = false;
        while (!quantidadeValida)
        {
            if (!uint.TryParse(Console.ReadLine(), out quantidade))
            {
                Console.WriteLine("Quantidade inválida Ò-Ó");
                Console.Write("Digite novamente: ");
            }
            else
                quantidadeValida = true;
        }

        Console.WriteLine("Agora digite os números decimais indicados *-*\n");

        decimal[] numeros = new decimal[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Número #{i + 1}: ");
            numeros[i] = decimal.Parse(Console.ReadLine());
        }

        decimal resultadoSoma = 0;
        for (int contador = 0; contador < quantidade; contador++)
        {
            resultadoSoma = resultadoSoma + numeros[contador];
        }

        decimal resultadoMedia = resultadoSoma / quantidade;
        decimal maiorNumero = numeros[0];
        decimal menorNumero = numeros[0];
        ;
        for (int contador = 0; contador < quantidade; contador++)
        {
            if (numeros[contador] >= maiorNumero)
            {
                maiorNumero = numeros[contador];
            }
            if (numeros[contador] <= menorNumero)
            {
                menorNumero = numeros[contador];
            }
        }
        Console.WriteLine($"Soma dos números: {resultadoSoma}");
        Console.WriteLine($"Média dos números: {resultadoMedia}");
        Console.WriteLine($"Maior número: {maiorNumero}");
        Console.WriteLine($"Menor número: {menorNumero}");
    }

    public static void Musica5Patinhos()
    {
        int patinhos = 0;
        Console.WriteLine("Quantos patinhos foram passear?");
        patinhos = Convert.ToInt32(Console.ReadLine());
        int quantidadeInicialPatinhos = patinhos;

        for (int i = patinhos; i >= 1; i--)
        {
            Console.WriteLine($"{patinhos} patinhos foram passear\r\nAlém das montanhas\r\nPara brincar\r\nA mamãe gritou: Quá, quá, quá, quá\r\nMas só {i - 1} patinhos voltaram de lá.");
            patinhos = patinhos - 1;
        }

        Console.WriteLine($"A mamãe patinha foi procurar\r\nAlém das montanhas\r\nNa beira do mar\r\nA mamãe gritou: Quá, quá, quá, quá\r\nE os {quantidadeInicialPatinhos} patinhos voltaram de lá.");
    }

    //Completo!

    public static void MusicaDosElefantes()
    {
        Console.WriteLine("Quantos elefantes?");
        int elefantes = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < elefantes; i++)
        {
            if (i == 1)
            {
                Console.WriteLine($"{i} elefante incomoda muita gente\n");
            }
            else if (i > 1)
            {
                Console.WriteLine($"{i} elefantes incomodam muita gente\n");
            }

            bool controle = true;
            int contador = 0;

            Console.Write($"{i + 1} elefantes ");
            while (controle)
            {
                if (contador == i + 1)
                {
                    controle = false;
                    break;
                }

                Console.Write(" incomodam ");
                contador++;
            }

            Console.Write(" muito mais!\n");
        }

        //Completo! T-T
    }

    public static void RetPreenchido()
    {
        Console.WriteLine("Digite um número entre 1 e 10 para escolher a altura");
        Console.Write("Altura: ");
        int altura = Convert.ToInt32(Console.ReadLine());
        bool validacao = false;
        while (!validacao)
        {
            if (altura < 1 || altura > 10)
            {
                Console.WriteLine("Valor inválido, digite apenas números entre 1 e 10");
                Console.Write("Altura: ");
                altura = Convert.ToInt32(Console.ReadLine());
            }
            else if (altura > 1 || altura < 10)
            {
                validacao = true;
            }
        }
        Console.WriteLine("Digite um número entre 1 e 10 para escolher a largura");
        Console.Write("Largura: ");
        int largura = Convert.ToInt32(Console.ReadLine());
        validacao = false;
        while (!validacao)
        {
            if (largura < 1 || largura > 10)
            {
                Console.WriteLine("Valor inválido, digite apenas números entre 1 e 10");
                Console.Write("Largura: ");
                largura = Convert.ToInt32(Console.ReadLine());
            }
            else if (largura > 1 || largura < 10)
            {
                validacao = true;
            }
        }

        for (int i = 0; i < altura; i++)
        {
            Console.Write("\n#");
            for (int j = 0; j < largura; j++)
            {
                Console.Write("#");
            }
        }
        //Completo :,) 
    }

    public static void RetContorno()
    {
        Console.WriteLine("Digite um número entre 1 e 10 para escolher a altura");
        Console.Write("Altura: ");
        int altura = Convert.ToInt32(Console.ReadLine());
        bool validacao = false;
        while (!validacao)
        {
            if (altura < 1 || altura > 10)
            {
                Console.WriteLine("Valor inválido, digite apenas números entre 1 e 10");
                Console.Write("Altura: ");
                altura = Convert.ToInt32(Console.ReadLine());
            }
            else if (altura > 1 || altura < 10)
            {
                validacao = true;
            }
        }
        Console.WriteLine("Digite um número entre 1 e 10 para escolher a largura");
        Console.Write("Largura: ");
        int largura = Convert.ToInt32(Console.ReadLine());
        validacao = false;
        while (!validacao)
        {
            if (largura < 1 || largura > 10)
            {
                Console.WriteLine("Valor inválido, digite apenas números entre 1 e 10");
                Console.Write("Largura: ");
                largura = Convert.ToInt32(Console.ReadLine());
            }
            else if (largura > 1 || largura < 10)
            {
                validacao = true;
            }
            for (int i = 0; i < altura; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < largura; j++)
                {
                    if (i == 0 || i == altura - 1)
                    {
                        Console.Write("#");
                    }
                    else if (j == 0 || j == largura - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }

            }
        }
    }
    
    public static void ExercicioFatorial()
    {
        double i, numero, fatorial;
        Console.Write("Informe um número inteiro positivo: ");
        numero = double.Parse(Console.ReadLine());
        fatorial = numero;
        bool numeroValido = false;
        while (!numeroValido)
        {
            if (numero < 0)
            {
                Console.WriteLine("Número inválido, digite apenas números inteiros positivos");
                Console.Write("Digite novamente o valor: ");
                numero = double.Parse(Console.ReadLine());
            }
            else if (numero == 0)
            {
                fatorial = 1;
                numeroValido = true;
            }
            else if(numero > 0)
            {
                for (i = numero - 1; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                }
                numeroValido = true;
            }
        }
        Console.WriteLine($"\nFatorial de {numero} é: {fatorial}");
    }
    public static void ExercicioFibonacci()
    {
        Console.Write("Digite a quantidade de interações usando um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());
        int numAnterior = 0;
        int numAtual = 1;
        int fibonacci = 0;
        bool nValido = false;
        while (!nValido)
        {
            if (n == 0)
            {
                Console.WriteLine("Digite pelo menos um número maior que zero");
                n = int.Parse(Console.ReadLine());
            }
            else if (n < 0)
            {
                Console.WriteLine("Digite apenas números positivos");
                n = int.Parse(Console.ReadLine());
            }
            else if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{fibonacci}, ");
                    fibonacci = numAnterior + numAtual;
                    numAnterior = numAtual;
                    numAtual = fibonacci;
                }
                nValido = true;
            }
        }
    }
}