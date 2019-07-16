using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasta_sem_título
{

    class ConcreteCreatorA : Fabrica{
        public override Produto FactoryMethod()
        {
            // PRODUTO CONCRETO A
            return new ConcreteProductA();
        }
    }
}
