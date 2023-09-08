namespace carro.Model{
    public class Carro{
        //atributos
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }
        public double Litragem {get; set;}
        public string Combustivel {get; set;}
        Motor motor = new Motor();
        

        //Métodos
        public void ApresentarDoc(){
            Console.WriteLine("Placa: "+ Placa);
            Console.WriteLine("Cor: "+ Cor);
            Console.WriteLine("Marca: "+ Marca);
            Console.WriteLine("Modelo: "+ Modelo);
            Console.WriteLine("Ano: "+ Ano);
            Console.WriteLine("Chassi: "+ Chassi);
            motor.Consumir(Litragem, Combustivel);
        }

        //Classe interna
        public class Motor{
            
            
            public void Consumir(double lit, string combustivel){
                if(combustivel == "Etanol"){
                    if(lit == 1.6){
                        Console.WriteLine("10Km por litro");
                    }
                    else{
                        Console.WriteLine("8km por litro");
                    }
                }
                else
                {
                    if(lit == 1.6){
                        Console.WriteLine("18Km por litro");
                    }
                    else{
                        Console.WriteLine("15km por litro");
                    }
                }
            }
        }
    }
}