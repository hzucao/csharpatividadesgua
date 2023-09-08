namespace escola.Model
{
    public class Escola
    {
        public string Nome { get; set; }
        List<Departamento> ListaDepartamentos = new List<Departamento>();
        public Escola(string nome)
        {
            this.Nome = nome;
            this.GetDepartamentos();
        }
        public void GetDepartamentos()
        {
            Departamento dep1 = new Departamento();
            dep1.Nome = "Secretaria";
            Departamento dep2 = new Departamento { Nome = "Biblioteca" };
            ListaDepartamentos.Add(dep1);
            ListaDepartamentos.Add(dep2);
        }
        public void ImprimeEscola()
        {
            Console.WriteLine("Escola: " + Nome);
            foreach (Departamento d in ListaDepartamentos)
            {
                Console.WriteLine("Departamento: " + d.Nome);
            }
        }
    }
}