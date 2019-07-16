using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strat{
    
    class MergeSort : I_SortStrategy{
        public override void Ordenar(List<string> lista){
            //list.MergeSort(); not-implemented
            Console.WriteLine("Estratégia: MergeSorted");
        }
    }
}