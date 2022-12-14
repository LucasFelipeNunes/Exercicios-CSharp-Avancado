using System;
namespace teste2
{
    class Aluno
    {
        public string Nome;
        public int Idade;
        public int Serie;
        public string Retorno()
        {
            return string.Format($"O aluno {Nome} tem {Idade} anos e pertence ao {Serie} ano");
        }
        public void RetornoConsole()
        {
            Console.WriteLine(Retorno());
        }
    }
    class Exercicio2Metodo
    {
        static void Main(string[] args)
        {
            Aluno joao = new Aluno();
            joao.Nome = "João";
            joao.Idade = 13;
            joao.Serie = 6;
            joao.RetornoConsole();
        }
    }
}