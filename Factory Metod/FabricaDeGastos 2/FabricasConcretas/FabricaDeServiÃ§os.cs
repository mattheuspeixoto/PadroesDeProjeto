using Fabrica.Consumo;
using Fabrica.Interfaces;
using Fabrica.Serviços;

namespace Fabrica.FabricasConcretas{
    // Instanciam os objetos da Interface IGastos (Cerveja ou Agua)
    public class FabricaDeServiços : I_FabServiço{


        public IServico CriarServico(string IServico)
        { if(IServico == "Arrumadeira")
             return new Arrumadeira();
           else 
              return new Lavanderia();
        }
    }
}