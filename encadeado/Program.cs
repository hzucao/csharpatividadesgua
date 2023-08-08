// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite sua temperatura:");
        float temperatura = float.Parse(Console.ReadLine());

        if(temperatura <35.5){
            Console.WriteLine("Hiportermia");
        }
        else if(temperatura < 37.6){
            Console.WriteLine("Normal");
        }
        else{
            Console.WriteLine("Febre");
        }
    }

}
