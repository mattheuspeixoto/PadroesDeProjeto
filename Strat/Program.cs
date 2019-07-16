﻿using System;

namespace Strat{
    class Program{
        static void Main(string[] args){
           
            SortedList listaDeEstudantes = new SortedList();

            listaDeEstudantes.AdicionarItem("Samual");
            listaDeEstudantes.AdicionarItem("Jimmy");
            listaDeEstudantes.AdicionarItem("Sandra");
            listaDeEstudantes.AdicionarItem("Vivek");
            listaDeEstudantes.AdicionarItem("Anna"); 

            Console.Clear();
            listaDeEstudantes.SetEstrategia(new ShellSort());
            listaDeEstudantes.Ordenar();

            listaDeEstudantes.SetEstrategia(new MergeSort());
            listaDeEstudantes.Ordenar();

            listaDeEstudantes.SetEstrategia(new QuickSort());
            listaDeEstudantes.Ordenar();

            // Wait for user
            Console.ReadKey();
            
        }
        
    }
}