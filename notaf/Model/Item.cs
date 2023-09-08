namespace nota.Model
{
    public class Item{
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double ValorUnitario{ get; set; }

        public Item(int codigo, string nome, double valorUnitario){
            this.Codigo = codigo;
            this.Nome = nome;
            this.ValorUnitario= valorUnitario;
        }
    }
    
}