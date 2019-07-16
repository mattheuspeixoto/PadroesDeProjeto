using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strat{
    class SortedList{
        private  List<string> _listaNomes = new List<string>();
        private I_SortStrategy _estrategiaDeOrdenacao;

        public void SetEstrategia(I_SortStrategy estrategia){
            this._estrategiaDeOrdenacao = estrategia;
        }

        public void AdicionarItem(string name){
            _listaNomes.Add(name);
        }

        public void Ordenar(){
            _estrategiaDeOrdenacao.Ordenar(_listaNomes);

            // Iterate over list and display results
            foreach (string nome in _listaNomes){
                Console.WriteLine(" " + nome);
            }
            Console.WriteLine();
        }
    }
}
