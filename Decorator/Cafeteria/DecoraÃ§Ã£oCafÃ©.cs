using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploCafeteria
{
    /// <summary>
    /// Interface para as decorações de café.
    /// </summary>
    public abstract class DecoraçãoCafé
    {
        protected DecoraçãoCafé decoração;

        public abstract Decimal ObterPreço();
        public abstract string ObterDescrição();

        protected DecoraçãoCafé()
        { 
        }

        protected DecoraçãoCafé(DecoraçãoCafé decoração)
        {
            this.decoração = decoração;
        }
    }
}
