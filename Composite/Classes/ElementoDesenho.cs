using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPComposite.Classes
{
    /// <summary>
    /// Classe abstrata para disponibilizar funcionalidades
    /// Componente
    /// </summary
    abstract class ElementoDesenho
    {
        protected string _nome;

        //// Construtor
        //public ElementoDesenho(string nome)
        //{
        //    this._nome = nome;
        //}

        public abstract void Adicionar(ElementoDesenho d);
        public abstract void Remover(ElementoDesenho d);
        public abstract void Exibir(int indent);

    }
}
