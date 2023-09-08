// See https://aka.ms/new-console-template for more information
using calc.Model;

namespace calc{
    public class Program{
        public static void Main(){
            var normal = new CalculadoraNormal();
            normal.Adicao(10,8);
            normal.Subtracao(10,8);
            normal.Multiplicacao(10,8);
            normal.Divisao(10,8);
            var cientifica = new CalculadoraCientifica();
            cientifica.Adicao(10,2);
            cientifica.Subtracao(10,2);
            cientifica.Multiplicacao(10,2);
            cientifica.Divisao(10,2);
            cientifica.Potencia(10,2);
        }
    }
}
