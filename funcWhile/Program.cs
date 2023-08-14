// See https://aka.ms/new-console-template for more information
//aula 14/08/2023 while
class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine());

        int controle =0;

        while(controle <= numero){ //enquanto a condição do while for verdadeira execute o bloco de dentro das chaves
             if(ePar(controle)){ //validação feita com a chamada da função ePar, foi passado a variavel controle com argumento para o parametro da função
                Console.WriteLine(controle);
             }
             controle = controle +1;
        }

    }

    public static bool ePar(int num){ //assinatura do metodo 
        //função para vaildar se o numero é par
        bool result = (num%2 ==0)? true  : false;
        return result;

    }
}
