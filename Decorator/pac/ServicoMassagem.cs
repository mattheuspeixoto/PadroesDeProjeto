using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem{
    class ServicoMassagem : PacoteDecorator{
        //Adiciona o serviço de massagem em um pacote
        public ServicoMassagem(Pacote pacote)
            : base(pacote, "Massagem", 50.0)
        {

        }
    }
}
