using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPComposite.Classes;

namespace DPComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar a estrutura da árvore
            ElementoComposto figura = new ElementoComposto("Figura");
            
            figura.Adicionar(new ElementoPrimitivo("Linha Vermelha"));
            figura.Adicionar(new ElementoPrimitivo("Círculo Azul"));
            figura.Adicionar(new ElementoPrimitivo("Caixa Verde"));

            // Criar uma ramificação na árvore de componentes
            ElementoComposto elementoComposto = new ElementoComposto("Dois Círculos");

            elementoComposto.Adicionar(new ElementoPrimitivo("Círculo Preto"));
            elementoComposto.Adicionar(new ElementoPrimitivo("Círculo Branco"));

            figura.Adicionar(elementoComposto);
            
            // Adicionar e remover um Elemento Primitivo 
            ElementoPrimitivo elementoPrimitivo = new ElementoPrimitivo("Linha Amarela");
            figura.Adicionar(elementoPrimitivo);
            //raiz.Remover(elementoPrimitivo);

            // Testar Primitivos
            ElementoPrimitivo elementoPrimitivo2 = new ElementoPrimitivo("Linha Azul");
            elementoPrimitivo.Adicionar(elementoPrimitivo2);
            
            // Exibir nós recursivamente
            figura.Exibir(1);

            Console.ReadKey();

        }
    }
}
