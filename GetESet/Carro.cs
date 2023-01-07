using System;
namespace GetESet { //Corrigir Programa
    public class Carro {
        private String Marca; 
        private String Nome; 
        private double Potencia;

        public Carro(String marca, String nome, double potencia) {
            Marca = marca; 
            Nome = nome; 
            Potencia = potencia;
        }

        public Carro()
        {
            
        }
        
        public string getMarca() {
            return Marca;
        }
        
        public void setMarca(string marca) {
            Marca = marca;
        }
        
        public string getNome() {
            return Nome;
        }
        
        public void setNome(String nome) {
            Nome = nome;
        }
        
        public double getPotencia() {
            return Potencia;
        }
        
        public void setPotencia(double potencia){
            Potencia = potencia;
        }
    }
}