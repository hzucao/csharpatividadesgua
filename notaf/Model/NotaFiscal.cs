using System.Diagnostics.CodeAnalysis;

namespace nota.Model{
    public class NotaFiscal{
        public long Numero { get; set; }
        public long Cpnj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorTotal { get; set; }
        public List<Item> Itens = new List<Item>(); 

        public NotaFiscal(long numero, long cpnj, DateTime dataEmissao){
            this.Numero  = numero;
            this.Cpnj = cpnj;
            this.DataEmissao = dataEmissao;
        }

        public void ImprimeNota(){
            Console.WriteLine("Nota Numero: "+ Numero);
            Console.WriteLine("Cnpj"+ Cpnj);
            Console.WriteLine("Data Emissão: "+ DataEmissao);
            foreach(Item i in Itens){
                ValorTotal = ValorTotal + i.ValorUnitario;
            }
            Console.WriteLine("Valor Total: "+ ValorTotal);
            foreach(Item i in Itens){
                Console.WriteLine("Codigo: "+i.Codigo+" Nome: "+ i.Nome+ " Valor Unitario: "+ i.ValorUnitario);
            }
        }
    }
}