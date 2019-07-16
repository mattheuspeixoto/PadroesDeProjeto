using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasta_sem_título
{
    
    class ConcreteCreatorB : Fabrica
    {
        public override Produto FactoryMethod()
        {
            // PRODUTO CONCRETO B
            return new ConcreteProductB();
        }
    }

}
