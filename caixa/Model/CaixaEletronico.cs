using System.Data;
using caixa.Interface;
namespace caixa.Model
{
    public class CaixaEletronico : ICaixa
    { //Atributo
        public double SaldoCaixa { get; set; }
        public long Terminal { get; set; }
        //Métodos
        //Metodo Construtor
        public CaixaEletronico(long terminal, double valorInicial)
        {
            this.Terminal = terminal;
            this.SaldoCaixa = valorInicial;
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
        public void RetirarDeposito(double valor)
        {
            SaldoCaixa = SaldoCaixa - valor;
        }
        public void ReporDinheiro(double valor)
        {
            SaldoCaixa = SaldoCaixa + valor;
        }
        public void ImprimeSaldo()
        {
            Console.WriteLine("----------Saldo Caixa Eletronico-------");
            Console.WriteLine("Terminal: " + Terminal);
            Console.WriteLine("Saldo: " + SaldoCaixa);
        }
    }
}