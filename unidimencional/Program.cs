// See https://aka.ms/new-console-template for more information
//aula 15/08/2023
class Program{
    public static void Main(){
        int[] numeros;
        numeros = new int[3] { 1, 2, 3};
        
        int[] numeros2 = new int[3];
        numeros2[0] = 4;
        numeros2[1] = 5;
        numeros2[2] = 6;

        for(int i=0; i< 3; i++) // i++ mesma coisa que i = i+1
         {
            Console.WriteLine("O numero do indice "+i+ " é igual a: " + numeros[i]);
         }

         foreach(int n in numeros2){
              Console.WriteLine(n);
         }
    }
}
