namespace aluno.Model{
    public class Aluno : Pessoa{
        //atributo
        public long Rm {get;set;}
        
        //Método
        public override void ImprimeDados(){
            base.ImprimeDados();
            Console.WriteLine("R.M.: "+ Rm);
        }

    }
}