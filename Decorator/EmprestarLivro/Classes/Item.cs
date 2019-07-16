using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPDecorator.Classes
{
    /// <summary>
    /// Classe Abstrata 'COMPONENT' 
    /// </summary>
    abstract class Item
    {
        private int _numeroCopias;

        // Propriedade
        public int NumeroCopias
        {
          get { return _numeroCopias; }
          set { _numeroCopias = value; }
        }

        public abstract void ExibirDadosDoItem();

    }
}
