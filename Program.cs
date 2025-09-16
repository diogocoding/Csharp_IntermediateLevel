using Csharp_IntermediateLevel.Models;



Pessoa p1 = new Pessoa(nome:"João", sobrenome:"Nacimento");

Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Buta");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();







/*Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Nascimento";
p1.Idade = 34;
p1.Apresentar();*/