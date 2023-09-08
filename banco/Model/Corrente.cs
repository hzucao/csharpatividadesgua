namespace banco.Model{
    public class Corrente: Conta{
        public long NumeroConta { get; set; }
        public double Tarifa { get; set; }

        public void ImprimeSaldo(){
            Console.WriteLine("O saldo atual da conta é: "+
            base.Saldo);
        }

    }
}