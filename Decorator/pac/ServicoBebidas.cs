using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem{
    class ServicoBebidas : PacoteDecorator{
        //Adiciona o serviço de bebidas em um pacote
        public ServicoBebidas(Pacote pacote)
            : base(pacote, "Bebidas", 400.0)
        {

        }
    }
}
