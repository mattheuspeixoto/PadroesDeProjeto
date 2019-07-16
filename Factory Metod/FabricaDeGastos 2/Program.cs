using System;
using Fabrica.FabricasConcretas;
using Fabrica.Interfaces;

namespace Fabrica{
    class Program{
        static void Main(string[] args)
        {
           I_FabConsumo fabcom; //Cria um objeto do tipo I_FabConsumo
           I_FabServiço fabser; //Cria um objeto do tipo I_FabServiços
           
           IConsumo consumo; // Cria um objeto do tipo Iconsumos
           IServico servico; //Cria um Objeto do tipoi IServico

           System.Console.Write("Digite o item desejado: ");
           string item = Console.ReadLine().ToUpper();  
           Console.Clear();         
        
           switch(item){
             case "CERVEJA" :                         
              fabcom = new FabricaDeConsumo(); //Instancia o objeto I_Fabconsumos com a Classe Fabrica Consumo
              consumo = fabcom.CriarConsumo("Cerveja");  // Instancia o objeto Iconsumos com a chamada q a fabrica retornar 
              consumo.ExibirInfo();
              break;

             case "AGUA" : 
              fabcom = new FabricaDeConsumo();
              consumo= fabcom.CriarConsumo("Agua");
              consumo.ExibirInfo();
              break;

             case "ARRUMADEIRA" : 
              fabser = new FabricaDeServiços(); //Instancia o objeto I_FabServico com a classe Servicos
              servico= fabser.CriarServico("Arrumadeira");//Instancia o objeto IServico com a chamada q a classe retornar 
              servico.ExibirInfo();
              break;

             case "LAVANDERIA" : 
              fabser= new FabricaDeServiços();
              servico = fabser.CriarServico("Lavanderia");
              servico.ExibirInfo();
              break;
          
             default :
                 System.Console.WriteLine("Item nao encontrado: ".ToUpper());
                break;
           
           }

        }
    }
}
