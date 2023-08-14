// See https://aka.ms/new-console-template for more information
//aula 14/08/2023 - do While
class Program{ //Faça
    public static void Main(){
        bool controle = true;

        do{
        Console.WriteLine("Digite um numero:");
        float numero = float.Parse(Console.ReadLine());
        Console.WriteLine("O numero "+numero+" multiplicado por 10 é = " + MultiplicaDez(numero));
        Console.WriteLine("Deseja multiplicar outro numero? Digite S = Sim ou N = Não");
        string simNao = Console.ReadLine();
        controle = (simNao == "S" || simNao == "s") ? true: false;

        }while(controle); //enquanto a condição do while for verdadeira

    }

    public static double MultiplicaDez(float num){ //função para multiplicar por 10 
        return num*10;
    }
}
