using Fabrica.Interfaces;

namespace Fabrica.Consumo
{
    public class Cerveja:IConsumo{
       
        public void ExibirInfo(){
            System.Console.WriteLine("O Item Selecionado foi Cerveja");
        } 
    }
}