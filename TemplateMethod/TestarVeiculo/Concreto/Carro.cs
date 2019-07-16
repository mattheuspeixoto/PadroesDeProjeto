using tm2.Abstrato;
using System;
namespace tm2.Concreto{
    class Carro : TestarVeiculo{
        public override void acelerar()
        {
            System.Console.WriteLine("Acelerando o Carro");
        }

        public override void desligar()
        {
            System.Console.WriteLine("Desligando o Carro");
        }

        public override void freiar()
        {
            System.Console.WriteLine("Freiando o Carro");
        }

        public override void ligar()
        {System.Console.WriteLine("Ligando o Carro");}

    }
}