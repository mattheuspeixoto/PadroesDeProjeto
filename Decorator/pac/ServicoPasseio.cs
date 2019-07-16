using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem
{
    class ServicoPasseio : PacoteDecorator
    {
        //Adiciona o serviço de passeio em um pacote
        public ServicoPasseio(Pacote pacote)
            : base(pacote, "Passeio", 250.0)
        {

        }

    }
}
