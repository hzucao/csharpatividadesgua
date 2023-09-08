// See https://aka.ms/new-console-template for more information
using escola.Model;
namespace escola
{
    public class Program
    {
        public static void Main()
        {
            var scholl = new Escola("Senai Duque de Caixias");
            scholl.ImprimeEscola();
        }
        
    }
}
