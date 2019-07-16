using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem{
    class PacoteCruzeiro: Pacote{
        public PacoteCruzeiro(String desc, Double preco)
            : base("Cruzeiro: " + desc, preco)
        {
            
        }
    }
}
