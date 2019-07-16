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
    public class Acúcar : DecoraçãoCafé
    {
        public Acúcar()
            : base()
        { }

        public Acúcar(DecoraçãoCafé decoração)
            : base(decoração)
        { }

        public override decimal ObterPreço()
        {
            return this.decoração != null ? 0m + this.decoração.ObterPreço() : 0m;
        }

        public override string ObterDescrição()
        {
            string descrição = "açúcar ";
            return this.decoração != null ? descrição + this.decoração.ObterDescrição() : descrição;
        }
    }
}
