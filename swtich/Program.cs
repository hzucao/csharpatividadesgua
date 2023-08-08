// See https://aka.ms/new-console-template for more information

using System;
class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero de 1 à 7");
        int diaSemana = int.Parse(Console.ReadLine());
        
        if(diaSemana ==1){
            Console.WriteLine("Domingo");
        }
        else if(diaSemana ==2){
            Console.WriteLine("Segunda");
        }
        else if (diaSemana ==3){
            Console.WriteLine("Terça");
        }
        else if (diaSemana ==4){
            Console.WriteLine("Quarta");
        }
        else if (diaSemana ==5){
            Console.WriteLine("Quinta");
        }
        else if (diaSemana ==6){
            Console.WriteLine("Sexta");
        }
        else if (diaSemana ==7){
            Console.WriteLine("Sabado");
        }
        else{
            Console.WriteLine("Numero digitado invalido");
        }


        switch(diaSemana){
            case 1: Console.WriteLine("Domingo"); break;
            case 2: Console.WriteLine("Segunda"); break;
            case 3: Console.WriteLine("Terça"); break;
            case 4: Console.WriteLine("Quarta"); break;
            case 5: Console.WriteLine("Quinta"); break;
            case 6: Console.WriteLine("Sexta"); break;
            case 7: Console.WriteLine("Sabado"); break;
            default: Console.WriteLine("Numero digitado invalido"); break;
        }

    }
}
