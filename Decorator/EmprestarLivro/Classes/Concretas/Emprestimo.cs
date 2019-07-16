using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPDecorator.Classes.Concretas
{
    /// <summary>
    /// 'ConcreteDecorator' 
    /// </summary>
    class Emprestimo : Decorador
    {
        protected List<string> emprestimos = new List<string>();

        // Construtor
        public Emprestimo(Item item)
            : base(item)
        {
        }

        public void EmprestarItem(string nomeAluno)
        {
            //adiciona o item na lista de empréstimos
            emprestimos.Add(nomeAluno);

            //decrementa o número de cópias disponíveis
            item.NumeroCopias--;
        }

        public void RetornarItem(string nomeAluno)
        {
            //remove o item da lista de empréstimos
            emprestimos.Remove(nomeAluno);

            //incrementa o número de cópias disponíveis
            item.NumeroCopias++;
        }

        public override void ExibirDadosDoItem()
        {
            base.ExibirDadosDoItem();

            Console.WriteLine(" Empréstimos em aberto:");

            foreach (string emprestimo in emprestimos)
            {
                Console.WriteLine(" -- Emprestimo: " + emprestimo);
            }
        }
    }

}
