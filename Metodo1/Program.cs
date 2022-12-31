using System;
namespace Metodo1
{
    class Aluno
    {
        public string Nome;
        public int Idade;
        public int Serie;
    }
    class Program{
        static void AA(string[] args)
        {
        Aluno joao = new Aluno();
        joao.Nome = "João";
        joao.Idade = 13;
        joao.Serie = 6;
        Console.WriteLine($"O aluno {joao.Nome} tem {joao.Idade} anos e pertence ao {joao.Serie} ano");
        }
    }
}
