using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strat{
    
    class QuickSort : I_SortStrategy{
        public override void Ordenar(List<string> lista){
            lista.Sort(); // Default is Quicksort
            Console.WriteLine("Estratégia: QuickSorted");
        }
    }

}