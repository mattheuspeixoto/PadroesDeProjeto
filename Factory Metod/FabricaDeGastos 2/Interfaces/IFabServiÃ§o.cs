using Fabrica;
namespace Fabrica.Interfaces{
    //Diz como a Fabrica deve se comportar
    public interface I_FabServiço{    
        IServico CriarServico(string IServico);
}}