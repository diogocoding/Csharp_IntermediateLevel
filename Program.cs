using Csharp_IntermediateLevel.Models;




Venda v1 = new Venda(1, "material de escritório", 25.00M);




/*int numero = 7;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"Onumero{numero} é "+ (ehPar ? "par" : "ímpar"));


/*
if (numero % 2 == 0)
{
    Console.WriteLine($"O numero {numero} é par");
}
else
{
    Console.WriteLine($"o numero {numero} é ímpar");
}






















/*Pessoa p1 = new Pessoa("Leonardo", "Buta");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");







/*LeituraArquivo arquivo = new LeituraArquivo();
//o "var" serve para que vc não precise passar o tipo da variável, ele já identifica sozinho
//caso não formos precisar de um dos retornos da tupla, podemos descartar, utilizando unteline no lugar do nome da variável
// assim -> var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
var (sucesso, linhasArquivo, quantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeDeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}



/*(int, string, string, decimal) tuplinha = (1, "diogo", "nascimento", 1.5M);


Console.WriteLine($"id:{tuplinha.Item1}");
Console.WriteLine($"Nome:{tuplinha.Item2}");
Console.WriteLine($"Sobrenome:{tuplinha.Item3}");
Console.WriteLine($"Altura:{tuplinha.Item4}");



/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("BA2", "Bahia");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine($"--------------");
//estados.Remove("BA");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Varificando a existência de {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"ja existe");
}
else {
    Console.WriteLine($"pode adicionar");
}





/*Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(3);
pilha.Push(39);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

    Console.WriteLine($"Removendo o elemento do topo da stack {pilha.Pop()}");


foreach (var item in pilha)
{
    Console.WriteLine(item);
}*/





/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} e adicionando o 10");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}*/






//new ExemploExcecao().Metodo1();







/*try
{
    string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}







/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1582.40M;
// :C -> pega as informações de localização do sistema de sua máquina e converte
//para o tipo de moeda respectivo
//
//já o "using System.Globalization;"
// e o
//"CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");"
//estabelecem uma moeda fixa, independente da região que você esteja
//caso queira que a cultura do sistema esteja de uma forma e a cultura 
//de um retorno específico estja em outra cultura pode fazer da seguinte foorma
// -> Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{valorMonetario:C}");





/*Pessoa p1 = new Pessoa(nome:"João", sobrenome:"Nacimento");

Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Buta");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();







Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Nascimento";
p1.Idade = 34;
p1.Apresentar();*/


