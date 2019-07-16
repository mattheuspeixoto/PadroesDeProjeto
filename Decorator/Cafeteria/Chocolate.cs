using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploCafeteria
{
    /// <summary>
    /// 'ConcreteComponent' 
    /// Componente Concreto
    /// </summary>
    public class Chocolate : DecoraçãoCafé
    {
        public Chocolate()
            : base()
        { }

        public Chocolate(DecoraçãoCafé decoração)
            : base(decoração)
        { }

        public override decimal ObterPreço()
        {
            return this.decoração != null ? 0.5m + this.decoração.ObterPreço() : 0.5m;
        }

        public override string ObterDescrição()
        {
            string descrição = "chocolate ";
            return this.decoração != null ? descrição + this.decoração.ObterDescrição() : descrição;
        }
    }
}
