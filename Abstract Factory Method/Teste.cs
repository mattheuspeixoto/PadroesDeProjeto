using System;

namespace absf{
    public class Teste{
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
            return carro;           
        }

       public void main(){
               Carro c1 = montarCarro("Luxo");
        }
    }
}