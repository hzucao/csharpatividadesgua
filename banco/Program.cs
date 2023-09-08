// See https://aka.ms/new-console-template for more information
using banco.Model;
namespace banco{
   public class Program{
       public static void Main(){
           var corrente = new Corrente();
            corrente.NumeroConta = 1233;
            corrente.Tarifa = 19.9;
            corrente.Depositar(1000);
            corrente.Sacar(corrente.Tarifa); 
            corrente.ImprimeSaldo();
       }
   }
}
