namespace caixa.Interface
{
    public interface ICaixa
    {
        public void Receber(double valor);
        public void Depositar(double valor);
        public void Sacar(double valor);
    }
}