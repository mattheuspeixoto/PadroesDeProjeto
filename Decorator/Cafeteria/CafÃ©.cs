using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploCafeteria
{
    /// <summary>
    /// Café básico, que pode ser incrementado com as decorações.
    /// </summary>
    public class Café : DecoraçãoCafé, ICafé
    {
        public Café(){ 
        }

        public Café(DecoraçãoCafé decoração){
            this.decoração = decoração;
        }

        public override string ObterDescrição(){
            string descrição = "Café";            
            if (this.decoração != null){
                descrição += " com " + decoração.ObterDescrição();
            }
            return descrição;
        }

        public override decimal ObterPreço(){
            return this.decoração != null ? 1.5m + this.decoração.ObterPreço() : 1.5m;
        }
    }
}
