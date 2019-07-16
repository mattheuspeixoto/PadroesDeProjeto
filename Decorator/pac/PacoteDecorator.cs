using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem
{
    abstract class PacoteDecorator : Pacote{
        protected Pacote pacote;
                
        //Ao criar um serviço para um pacote: 
        //- O decorador já adiciona (concatena) o nome do serviço ao nome do pacote já existente
        //- O decorador já adiciona (soma) o preço do serviço no preço do pacote já existente
        public PacoteDecorator(Pacote pacote, String descServico, Double precoServico)
            : base(pacote.getDesc() + " + " + descServico, pacote.getPreco() + precoServico)
        {
            this.pacote = pacote;
        }
    }
}
