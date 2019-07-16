using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPComposite.Classes
{  
    /// <summary>
    /// A classe Composite
    /// </summary>
    class ElementoComposto : ElementoDesenho
    {
        private List<ElementoDesenho> elementos = new List<ElementoDesenho>();
        // Construtor
        //
        // ": base" - especifica qual construtor da classe base deve ser chamado 
        // durante a criação de instâncias da classe derivada.
        public ElementoComposto(string nome){
            base._nome = nome;
        }
        public override void Adicionar(ElementoDesenho d){
            elementos.Add(d);
        }
        public override void Remover(ElementoDesenho d){
            elementos.Remove(d);
        }
        public override void Exibir(int id){
            Console.WriteLine(new String('-', id) + "+ " + _nome);

            // Display each child element on this node
            foreach (ElementoDesenho desenho in elementos)
            {
                desenho.Exibir(id + 2);
            }
        }
    }

}
