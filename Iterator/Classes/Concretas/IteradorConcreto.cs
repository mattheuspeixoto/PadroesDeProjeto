 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Classes.Abstratas;

namespace Iterator.Classes.Concretas{
    //Interador possui um Agregado(Lista) e um indice para manipular as posicoes 
    class IteradorConcreto : Iterador{
        private AgregadoConcreto _agregado;
        private int _atual = 0;

        // Construtor
        public IteradorConcreto(AgregadoConcreto agregado){
            this._agregado = agregado;
        }

        // Retorna o primeiro item
        public override object Primeiro(){
            return _agregado[0];
        }

        // Retorna o próximo item
        public override object Proximo(){
            object objetoRetorno = null;

            if (_atual < _agregado.Tamanho - 1){
                objetoRetorno = _agregado[++_atual];
            }

            return objetoRetorno;
        }

        // Retorna o item atual dentro da iteração
        public override object ItemAtual(){
            return _agregado[_atual];
        }
    
        // Verifica se a iteração terminou
        public override bool Fim(){
        return _atual >= _agregado.Tamanho;
        }
    }
}
