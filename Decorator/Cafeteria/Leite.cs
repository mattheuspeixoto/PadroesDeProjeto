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
    public class Leite : DecoraçãoCafé
    {
        public Leite()
            : base()
        { }

        public Leite(DecoraçãoCafé decoração)
            : base(decoração)
        { }

        public override decimal ObterPreço()
        {
            return this.decoração != null ? 0.25m + this.decoração.ObterPreço() : 0.25m;
        }

        public override string ObterDescrição()
        {
            string descrição = "leite ";
            return this.decoração != null ? descrição + this.decoração.ObterDescrição() : descrição;
        }
    }
}
