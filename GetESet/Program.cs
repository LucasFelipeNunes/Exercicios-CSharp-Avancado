using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetESet
{
    public class Program
    {   
        static void Main(string[] args){
            Carro carro = new Carro();
            
            Console.Write("Digite o nome do carro: ");
            carro.setNome(Console.ReadLine());

            Console.Write("Digite a marca do carro: ");
            carro.setMarca(Console.ReadLine());

            Console.Write("Digite a potencia do carro: ");
            carro.setPotencia(double.Parse(Console.ReadLine()));

            Console.WriteLine("Nome: " + carro.getNome());
            Console.WriteLine("Marca: " + carro.getMarca());
            Console.WriteLine("Potencia: " + carro.getPotencia());
        }
    }
}