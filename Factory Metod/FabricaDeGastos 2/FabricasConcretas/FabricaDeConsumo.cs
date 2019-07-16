using Fabrica.Consumo;
using Fabrica.Interfaces;
using Fabrica.Serviços;

namespace Fabrica.FabricasConcretas{
    // Instanciam os objetos da Interface IGastos (Cerveja ou Agua)
    public class FabricaDeConsumo : I_FabConsumo{
        public IConsumo CriarConsumo(string IConsumo){
            if(IConsumo=="Agua"){
                return new Agua();
            }else
            return new Cerveja();
        }       


    }
}
