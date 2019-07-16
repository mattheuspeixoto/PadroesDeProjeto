using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Classes.Comum{
        class ClasseB{
        public int numero { get; set; }
        public string nome { get; set; }        
        
        public override String ToString(){
            nome= "CLasseB";
            return "Nome:"+this.nome;
        }
    }
}
