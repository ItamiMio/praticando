using  ExemplosExplorando.Models;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados ["MG"]);

// foreach (var item in estados)
// {
//     Console.WriteLine ($"Chave: {item.Key} Valor: {item.Value}");
// }

// Console.WriteLine("-------------");

// estados.Remove("BA");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
// }

// string chave = "BA2";
// Console.WriteLine ($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine ($"Valor inexistente. É recomendado adicionar a chave: {chave}");
// }

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo : {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine (item);
// }

// Console.WriteLine ($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine (item);
// }

//new ExemploExcecao().Metodo1();

// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (String linha in linhas)
// {
//     Console.WriteLine (linha);
// }

// } catch (Exception ex)
// {
//     Console.WriteLine ($"Ocorreu uma exceção genérica. {ex.Message}");
// } 
// finally
// {
//     Console.WriteLine ("Chegou até aqui");
// }


//string dataString = "2026/18/26 14:57";
//bool sucesso = DateTime.TryParseExact(dataString, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

//if (sucesso)
//{
    //Console.WriteLine ($"Conversão com sucesso! Data: {data}");
//}
//else
//{
    //Console.WriteLine ("A data não pôde ser convertida");
//}

//DateTime data = DateTime.Parse(dataString);
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine (data.ToShortDateString());
//Console.WriteLine (data.ToShortTimeString());


//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//decimal valorMonetario = 1582.40M;
//Console.WriteLine (valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

//double porcentagem = .3421;
//Console.WriteLine (porcentagem.ToString("P"));  

//int numero = 123456;
//Console.WriteLine (numero.ToString("##-##-##"));


//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAlunos(p1);
//cursoDeIngles.AdicionarAlunos(p2);
//cursoDeIngles.ListarAlunos();

//Pessoa p1 = new Pessoa();
//p1.Nome = "Itami";
//p1.Sobrenome = "Mio";
//p1.Idade = 26;
//p1.Apresentar();