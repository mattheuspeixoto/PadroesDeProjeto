using System;
using Fabrica.FabricasConcretas;
using Fabrica.Interfaces;

namespace Fabrica{
    class Program{
        static void Main(string[] args){
           I_FabGastos fabrica; //Cria um objeto do tipo I_Fabconsumos           
           IConsumo consumo;       // Cria um objeto do tipo Iconsumos
           IServico servico; //Cria um Objeto do tipoi IServico
           
           System.Console.Write("Digite o item desejado: ");
           string item = Console.ReadLine();     
           Console.Clear();      
        
           switch(item){
             case "Cerveja" :                         
              fabrica = new FabricaDeGastos(); 
              consumo = fabrica.CriarConsumo("Cerveja");  // Instancia o objeto Iconsumos com a chamada q a fabrica retornar 
              consumo.ExibirInfo();
              break;

             case "Agua" : 
              fabrica = new FabricaDeGastos();
              consumo= fabrica.CriarConsumo("Agua");
              consumo.ExibirInfo();
              break;

             case "Arrumadeira" : 
              fabrica = new FabricaDeGastos(); 
              servico= fabrica.CriarServico("Arrumadeira");//Instancia o objeto IServico com a chamada q a classe retornar 
              servico.ExibirInfo();
              break;

             case "Lavanderia" : 
              fabrica= new FabricaDeGastos();
              servico = fabrica.CriarServico("Lavanderia");
              servico.ExibirInfo();
              System.Console.WriteLine(  );
              break;
          
             default :
                 System.Console.WriteLine("Item nao encontrado:"  );
                break;
            }

        }
    }
}
