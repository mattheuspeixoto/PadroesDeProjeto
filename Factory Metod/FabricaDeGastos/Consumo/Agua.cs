using Fabrica.Interfaces;

namespace Fabrica.Consumo
{
    public class Agua : IConsumo
    {
        public void ExibirInfo()
        {
            System.Console.WriteLine("Agua");
        }
    }
}