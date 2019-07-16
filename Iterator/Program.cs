
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Classes.Concretas;
using Iterator.Classes.Abstratas;
using Iterator.Classes.Comum;

namespace Iterator{
    class Program{
        static void Main(string[] args){
            // Criando dados para testes
            AgregadoConcreto a = new AgregadoConcreto();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            var meuObjetoA = new ClasseA();
            meuObjetoA.nome = "Antonio";
            meuObjetoA.numero= 10;
            a[4] = meuObjetoA;

            var meuObjetoB = new ClasseB();
            meuObjetoB.nome = "Chico";
            meuObjetoB.numero= 20;
            a[5] = meuObjetoB;

            // Criar iterador de fornecer agregado

           // Iterador meuIterador = new IteradorConcreto(a);
            Iterador meuIterador = a.CriarIterador();

            Console.WriteLine("Iteração sobre a coleção: ");
            
            object item = meuIterador.Primeiro();
            
            while (item != null){
                // Para os objetos complexos irá imprimir apenas a referência para a sua classe
                Console.WriteLine(item.ToString());
                item = meuIterador.Proximo();
            }
            
            // Aguardar o usuário digitar algo para fechar a tela
            Console.ReadKey();
        }
    }
}
