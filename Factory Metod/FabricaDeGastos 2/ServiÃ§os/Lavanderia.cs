using Fabrica.Interfaces;

namespace Fabrica.Serviços {
    public class Lavanderia : IServico {
        public void ExibirInfo () {
            System.Console.WriteLine ("O Item Selecionado foi Lavanderia");
        }
    }
}