using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execução de Consultas

            DataAccessObject daoCategorias = new Categorias();
            daoCategorias.RodarConsulta();

            DataAccessObject daoProdutos = new Produtos();
            daoProdutos.RodarConsulta();

            Console.ReadKey();
        }
    }
}
