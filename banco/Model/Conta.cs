namespace banco.Model{
    public abstract class Conta{
        protected double Saldo{get;set;}

        public void Depositar(double valor){
            this.Saldo = this.Saldo + valor;
        }
        public void Sacar(double valor){
            this.Saldo = this.Saldo - valor;
        }
    }
}