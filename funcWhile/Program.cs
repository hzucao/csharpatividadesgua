// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine());

        int controle =0;

        while(controle <= numero){
             if(ePar(controle)){
                Console.WriteLine(controle);
             }
             controle = controle +1;
        }

    }

    public static bool ePar(int num){ //assinatura do metodo
        bool result = (num%2 ==0)? true  : false;
        return result;

    }
}
