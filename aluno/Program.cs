// See https://aka.ms/new-console-template for more information
using aluno.Model;
namespace aluno{
    public class Program{
        public static void Main(){
            // var pessoa = new Pessoa();
            // pessoa.setCpf(123);
            // pessoa.Nome = "Heitor";
            // pessoa.Sexo = "Masculino";
            // pessoa.ImprimeDados();

            var aluno = new Aluno();
            aluno.Nome = "Heitor";
            aluno.setCpf(123);
            aluno.Sexo = "Masculino";
            aluno.Rm = 1234;
            aluno.ImprimeDados();
        }
    }
}
