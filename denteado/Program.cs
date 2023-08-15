// See https://aka.ms/new-console-template for more information
//aula 15/08/2023
class Program{
    public static void Main(){
        float[][] itens = new float[3][];
        string[] nomeitens = new string[3];

        for(int i=0; i<3;i++){
            Console.WriteLine("Digite o nome produto:");
            nomeitens[i] = Console.ReadLine();
            itens[i] = new float[2];
            Console.WriteLine("Digite a quantidade:");
            itens[i][0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario:");
            itens[i][1] = float.Parse(Console.ReadLine());

        }
         
        for(int i=0; i <3; i++){
           Console.WriteLine("Produto "+ i + ":"+ nomeitens[i] + " Quantidade: " +itens[i][0] + " Valor: "+ itens[i][1]+ " Total: " + itens[i][0]*itens[i][1]); 
        } 
    }
}
