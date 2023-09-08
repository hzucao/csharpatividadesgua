// See https://aka.ms/new-console-template for more information
using nota.Model;

namespace nota{
    public class Program{
        public static void Main(){
            DateTime dtEmissao = DateTime.Now;
            var nf = new NotaFiscal(123, 12345678910111, dtEmissao);
            List<Item> itensNota = new List<Item>();
            itensNota.Add(new Item(1, "Agua Mineral de Fresco", 3));
            itensNota.Add(new Item(2, "Vencetex 3L", 7.5));
            nf.Itens = itensNota;
            nf.ImprimeNota();
        }
    }
}
