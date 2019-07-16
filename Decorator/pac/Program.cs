using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DecoratorPacotesViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("== PACOTE FÉRIAS ==");

            //Cria-se um pacote de um tipo
            Pacote pacoteDeViagem = new PacotePraia("Beberibe-CE", 1500.0);

            //Adiciona servicos ao pacote criado, atualizando o pacote
            pacoteDeViagem = new ServicoBebidas(pacoteDeViagem);
            pacoteDeViagem = new ServicoBebidas(pacoteDeViagem);
            pacoteDeViagem = new ServicoPasseio(pacoteDeViagem);
      
            Console.WriteLine("INCLUSO");
            Console.WriteLine(pacoteDeViagem.getDesc());
            Console.WriteLine("TOTAL R$ " + pacoteDeViagem.getPreco());

            //OUTRA FORMA DE CRIAR OS PACOTES

            Console.WriteLine("\n\n== PACOTE FÉRIAS 2==");

            Pacote pacoteDeViagem2 = new ServicoMassagem(new ServicoBebidas(new PacoteCampo("Pacoti-CE", 2000.0)));

            Console.WriteLine("INCLUSO");
            Console.WriteLine(pacoteDeViagem2.getDesc());
            Console.WriteLine("TOTAL R$ " + pacoteDeViagem2.getPreco());

            Console.ReadKey();
        }
    }
}