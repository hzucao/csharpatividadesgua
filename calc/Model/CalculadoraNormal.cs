using calc.Interface;

namespace calc.Model{
    public class CalculadoraNormal : ICalculadora
    {
        
        public void Adicao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Adicao: "+ (valor1+valor2));
        
        }

        public void Divisao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Divisão: "+ (valor1/valor2));
        }

        public void Multiplicacao(double valor1, double valor2)
        {
           Console.WriteLine("Resultado Multiplicação: "+ (valor1*valor2));
        }

        public void Subtracao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Subtração: "+ (valor1-valor2));
        }

      
    }
}