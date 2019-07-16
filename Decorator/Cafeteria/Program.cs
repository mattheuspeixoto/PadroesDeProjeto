using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploCafeteria {
    class Program {
        static void Main (string[] args) {
            ICafé caféPuro = new Café();
            ICafé caféComAçúcar = new Café(new Acúcar ());
            ICafé caféComLeite = new Café(new Leite (new Acúcar ()));
            ICafé cappuccino = new Café(new Leite (new Chocolate (new Acúcar ())));
            ICafé cappuccinoChantilly = new Café(new Leite (new Chocolate (new Acúcar (new Chantitlly ()))));

            MostrarCafé(caféPuro);
            MostrarCafé(caféComAçúcar);
            MostrarCafé(caféComLeite);
            MostrarCafé(cappuccino);
            MostrarCafé(cappuccinoChantilly);

            Console.ReadKey ();
        }

        static void MostrarCafé(ICafé café) {
            Console.WriteLine (café.ObterDescrição ());
            Console.WriteLine (café.ObterPreço ().ToString ("c"));
            Console.WriteLine ("---------------------------------------------");
        }
    }
}