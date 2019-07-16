using tm2.Abstrato;
using System;
namespace tm2.Concreto{

    class Caminhao : TestarVeiculo
    {
        public override void acelerar()
        {
            Console.WriteLine("Acelerando o Caminhao");
        }

        public override void desligar()
        { 
            Console.WriteLine("Desligando o caminhao");
        }

        public override void freiar()
        {
            Console.WriteLine("Freiando o Caminhao");
        }

        public override void ligar()
        {
            Console.WriteLine("Ligando o Caminhao");
        }
    }
}

