using tm2.Abstrato;
using System;
namespace tm2.Concreto{

    class Moto : TestarVeiculo
    {
        public override void acelerar()
        {
            Console.WriteLine("Acelerando a moto");
        }

        public override void desligar()
        {
            Console.WriteLine("Desligando a moto");
        }

        public override void freiar()
        {
            Console.WriteLine("Freiando a moto");
        }

        public override void ligar()
        {
            Console.WriteLine("Ligando a moto");
        }
    }
}