using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Classes.Abstratas
{
    abstract class Iterador
    {
        public abstract object Primeiro();
        public abstract object Proximo();
        public abstract bool Fim();
        public abstract object ItemAtual();
    }
}
