using System.Dynamic;
using caixa.Interface;
namespace caixa.Model
{
    public class CaixaBanco : ICaixa
    {
        //Atributos
        public double SaldoCaixa { get; set; }
        public string Operador { get; set; }
        public long CodigoCaixa { get; set; }
        //Metodos
        //Metodo Construtor
        public CaixaBanco(string operador, long codigoCaixa)
        {
            this.Operador = operador;
            this.CodigoCaixa = codigoCaixa;
        }
        public void Depositar(double valor)
        {
            SaldoCaixa = SaldoCaixa + valor;
        }
        public void Receber(double valor)
        {
            SaldoCaixa = SaldoCaixa + valor;
        }
        public void Sacar(double valor)
        {
            SaldoCaixa = SaldoCaixa - valor;
        }
        public void AbrirCaixa(double valorInicial)
        {
            SaldoCaixa = valorInicial;
        }
        public void ImprimeSaldo()
        {
            Console.WriteLine("-------------Saldo do Caixa---------");
            Console.WriteLine("Operador: " + Operador);
            Console.WriteLine("Caixa: " + CodigoCaixa);
            Console.WriteLine("Saldo atual: " + SaldoCaixa);
        }
    }
}