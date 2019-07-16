using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Classes.Abstratas;
using System.Collections;

namespace Iterator.Classes.Concretas{
    // Agredado possui uma lista e metodos que retornam  tamanho, dado na posicao e fazem insert
    class AgregadoConcreto : Agregado{
        //Lista genérica de itens
        private ArrayList _itens = new ArrayList();

        public override Iterador CriarIterador(){
            return new IteradorConcreto(this);
        }

        // Identifica a quantidade de itens
        public int Tamanho{
            get { return _itens.Count; }
        }

        // Indexador, evitando chamar o Insert no programa principal, utilizado pelo programador/usuário
        public object this[int indice]{
            get { return _itens[indice]; }

            //não se utiliza o "Add" pois iria adicionar ao fim da lista, o "Insert" adiciona em um índice específico
            set { _itens.Insert(indice, value); }
        }
    }
}
