// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite o primeiro numero inteiro:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero inteiro:");
        int num2 = int.Parse(Console.ReadLine());
        
        //metedo tradicional
        if(num1 == num2){
            Console.WriteLine("Igual");
        }
        else{
            Console.WriteLine("Diferente");
        }
        
        //operador ternario
        string resultado = (num1 == num2) ? "Igual" : "Diferente";
        Console.WriteLine(resultado);

    }
}
