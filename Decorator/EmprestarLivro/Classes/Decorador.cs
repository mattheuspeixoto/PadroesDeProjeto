using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPDecorator.Classes
{
      /// <summary>
      /// Classe Abstrata 'DECORATOR' 
      /// </summary>
    abstract class Decorador : Item
    {
        protected Item item;

        // Constructor
        public Decorador(Item item)
        {
            this.item = item;
        }

        public override void ExibirDadosDoItem()
        {
            item.ExibirDadosDoItem();
        }
    }
}
