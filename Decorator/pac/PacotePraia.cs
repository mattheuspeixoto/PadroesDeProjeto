using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem{
    class PacotePraia: Pacote{
        public PacotePraia(String desc, Double preco)
            : base("Praia: " + desc, preco)
        {
            
        }
    }
}
