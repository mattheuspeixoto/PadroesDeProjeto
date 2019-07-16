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
    public class Chantitlly : DecoraçãoCafé
    {
        public Chantitlly()
            : base()
        { }

        public Chantitlly(DecoraçãoCafé decoração)
            : base(decoração)
        { }

        public override decimal ObterPreço()
        {
            return this.decoração != null ? 0.75m + this.decoração.ObterPreço() : 0.75m;
        }

        public override string ObterDescrição()
        {
            string descrição = "chantilly ";
            return this.decoração != null ? descrição + this.decoração.ObterDescrição() : descrição;
        }
    }
}
