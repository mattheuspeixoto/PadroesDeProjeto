using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPComposite.Classes
{
    /// <summary>
    /// A classe Folha
    /// </summary>
    class ElementoPrimitivo : ElementoDesenho
    {
        // Construtor
        //
        // ": base" - especifica qual construtor da classe base 
        // deve ser chamado 
        // durante a criação de instâncias da classe derivada.
        public ElementoPrimitivo(string nome){
            base._nome = nome;
        }

        //Sem implementação útil
        public override void Adicionar(ElementoDesenho c){
            Console.WriteLine("Não é possível Adicionar para um Elemento\n");
        }

        //Sem implementação útil
        public override void Remover(ElementoDesenho c){
            Console.WriteLine("Não é possível Remover de um Elemento\n");
        }

        public override void Exibir(int id){
            Console.WriteLine(new String('-', id) + " " + _nome);
        }
    }
}
