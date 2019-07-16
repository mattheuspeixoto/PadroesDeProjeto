using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPDecorator.Classes.Concretas
{
    /// <summary>
    /// 'ConcreteComponent' 
    /// Componente Concreto
    /// </summary>
    class Livro : Item
    {
        private string _autor;
        private string _titulo;

        // Construtor
        public Livro(string autor, string titulo, int numeroCopias)
        {
            this._autor = autor;
            this._titulo = titulo;
            this.NumeroCopias = numeroCopias;
        }

        public override void ExibirDadosDoItem()
        {
            Console.WriteLine("\nLivro ------ ");
            Console.WriteLine(" Autor: {0}", _autor);
            Console.WriteLine(" Título: {0}", _titulo);
            Console.WriteLine(" # Cópias Disponíveis: {0}", NumeroCopias);
        }
    }

}
