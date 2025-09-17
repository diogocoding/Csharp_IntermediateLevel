using Csharp_IntermediateLevel.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

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


