using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pasta_sem_título
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um array de Criadores
            Fabrica[] creators = new Fabrica[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iteração sobre criadores e produtos criados
            foreach (Fabrica creator in creators)
            {
                Produto product = creator.FactoryMethod();
                Console.WriteLine("Created " + product.GetType().Name);
            }

            // Pausar a tela
            Console.ReadKey();

        }
    }
}
