using Fabrica;
namespace Fabrica.Interfaces{
    //Diz como a Fabrica deve se comportar
    public interface I_FabGastos{
        IConsumo CriarConsumo(string IConsumo);
        //vai retornar um objeto q instancie a interface IGastos(Cerveja ou Agua);
        
        IServico CriarServico(string IServico);
}}