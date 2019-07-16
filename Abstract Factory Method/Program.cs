using System;

namespace absf{
    class Program{

        private static Carro montarCarro(String tipo){
            CarroFactory cf = null;
            switch(tipo){
                case "luxo" :                
                    cf= new CarroLuxoFactory();
                     break;
                
                default :               
                    cf= new CarroPopularFactory();
                     break;

                    
            }
            Carro carro = new Carro();
            carro.r = cf.montarRoda();
            carro.s= cf.montarSom();
            return carro;      }

        static void Main(string[] args)
        {
              Carro c1 = montarCarro("Luxo");
        }
    }
}




