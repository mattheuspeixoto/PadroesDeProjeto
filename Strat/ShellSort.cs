using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strat{
    
    class ShellSort : I_SortStrategy{
        public override void Ordenar(List<string> lista){
            //list.ShellSort(); not-implemented
            Console.WriteLine("Estratégia: ShellSorted");
        }
    }
}