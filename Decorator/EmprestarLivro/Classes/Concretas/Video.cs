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
    class Video : Item
    {
        private string _diretor;
        private string _titulo;
        private int _duracao;

        // Construtor
        public Video(string diretor, string titulo,
          int numeroCopias, int duracao)
        {
            this._diretor = diretor;
            this._titulo = titulo;
            this.NumeroCopias = numeroCopias;
            this._duracao = duracao;
        }

        public override void ExibirDadosDoItem()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Diretor: {0}", _diretor);
            Console.WriteLine(" Título: {0}", _titulo);
            Console.WriteLine(" # Cópias Disponíveis: {0}", NumeroCopias);
            Console.WriteLine(" Duração: {0}", _duracao);
        }
    }

}
