// See https://aka.ms/new-console-template for more information
using caixa.Model;

namespace caixa
{
    public class Program
    {
        public static void Main()
        {
            var caixabanco = new CaixaBanco("Heitor", 123);
            caixabanco.AbrirCaixa(1000);
            caixabanco.Receber(1000);
            caixabanco.Depositar(2);
            caixabanco.Sacar(1500);
            caixabanco.ImprimeSaldo();
            var eletronico = new CaixaEletronico(1234, 10000);
            eletronico.Sacar(500);
            eletronico.Depositar(200);
            eletronico.ImprimeSaldo();
        }
    }
}
