namespace time.Model
{
    public class Time
    {
        public string Nome { get; set; }
        public List<Jogador> Jogadores = new List<Jogador>();

        
        public Time(string nome)
        {
            Nome = nome;
        }

        public void ImprimeTime()
        {
            Console.WriteLine("Time: " + Nome);
            foreach (Jogador j in Jogadores)
            {
                Console.WriteLine("Fera: " + j.Nome);
            }
        }
    }
}