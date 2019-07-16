using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DPDecorator.Classes.Concretas;

namespace DPDecorator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criar Livro
            // - Autor, Título e Cópias
            Livro livro = new Livro("Gama", "Design Pattern - Padrão de Projeto", 10);
            livro.ExibirDadosDoItem();

            // Criar Vídeo
            // - Diretor, Título, Cópias e Duração
            Video video = new Video("Halder Gomes", "Cine Holliúdy", 23, 92);
            video.ExibirDadosDoItem();

            Console.WriteLine("\nEmprestando Vídeo:");

            Emprestimo emprestimosVideo = new Emprestimo(video);

            emprestimosVideo.EmprestarItem("Aluno #1");
            emprestimosVideo.EmprestarItem("Aluno #2");
            emprestimosVideo.EmprestarItem("Aluno #3");
            emprestimosVideo.EmprestarItem("Aluno #4");

            emprestimosVideo.ExibirDadosDoItem();

            Console.WriteLine("\nEmprestando Livro:");

            Emprestimo emprestimosLivro = new Emprestimo(livro);

            emprestimosLivro.EmprestarItem("Aluno #1");
            emprestimosLivro.EmprestarItem("Aluno #2");

            emprestimosLivro.ExibirDadosDoItem();


            Console.ReadKey();

        }
    }
}
