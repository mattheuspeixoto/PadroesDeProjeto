using tm2.Abstrato;
using System;
namespace tm2.Concreto{

    class Aviao : TestarVeiculo
    {
        public override void acelerar()
        {
            Console.WriteLine("Acelerando o Aviao");
        }

        public override void desligar()
        {
            Console.WriteLine("Desligando o Aviao");
        }

        public override void freiar()
        {
            Console.WriteLine("Freiando o Aviao");
        }

        public override void ligar()
        {
            Console.WriteLine("Ligando o Aviao");
        }
    }
}