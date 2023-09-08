// See https://aka.ms/new-console-template for more information
using carro.Model;
namespace carro{
    public class Program{
        public static void Main(){
            //Instanciamento do Objeto de uma classe
            var carro = new Carro();
            //Atribuindo valor aos atributos
            carro.Placa = "ABC0D12";
            carro.Cor = "Branco";
            carro.Marca = "Mercedes-Bens";
            carro.Modelo = "G63";
            carro.Ano = 2023;
            carro.Chassi = "Abcd1234X";
            carro.Litragem = 1.6;
            carro.Combustivel = "Etanol";
            //Chamando o metodo
            carro.ApresentarDoc();
        }
    }
}