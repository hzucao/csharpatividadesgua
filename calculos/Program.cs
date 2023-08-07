// See https://aka.ms/new-console-template for more information
class Program{

    public static void Main(){
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota:");
        float nota1 = float.Parse( Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        float nota2 = float.Parse( Console.ReadLine());

        float media;
        media = (nota1+nota2)/2;

        Console.WriteLine("O aluno " + nome + "tem a média: "+ media);

    }

}
