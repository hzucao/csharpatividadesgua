// See https://aka.ms/new-console-template for more information
using time.Model;
namespace time
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var timeTop = new Time("Palmeiras");
            List<Jogador> jogadoresTime = new List<Jogador>();
            jogadoresTime.Add(new Jogador("Weverton"));
            jogadoresTime.Add(new Jogador("Rony"));
            jogadoresTime.Add(new Jogador("Dudu"));
            jogadoresTime.Add(new Jogador("Gomes"));
            jogadoresTime.Add(new Jogador("Veiga"));
            jogadoresTime.Add(new Jogador("Endric"));
            timeTop.Jogadores = jogadoresTime;
            timeTop.ImprimeTime();
        }
    }
}
