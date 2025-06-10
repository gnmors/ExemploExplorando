using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Giovanni";
p1.Sobrenome = "Morais";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();










// Pessoa p1 = new Pessoa();
// p1.Nome = "Giovanni";
// p1.Sobrenome = "Morais";
// p1.Idade = 20;
// p1.Apresentar();
