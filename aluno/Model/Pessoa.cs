namespace aluno.Model{
    public class Pessoa{
        //atributos
        public string Nome { get; set; }
        private long Cpf;
        public string Sexo { get; set; }
        
        //Métodos
        public long getCpf(){
            return Cpf;
        }
        public void setCpf(long cpf){
            this.Cpf = cpf;
        }
        public virtual void ImprimeDados(){
            Console.WriteLine("Nome: "+ this.Nome);
            Console.WriteLine("Cpf: "+ this.getCpf());
            Console.WriteLine("Sexo"+ this.Sexo);
        }

    }
}