using Library.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    class Program {
        static void Main(string[] args) {

            var biblioteca = new Biblioteca();

            // Cadastrar alguns livros
            biblioteca.CadastrarLivro("O Senhor dos Anéis", "J.R.R. Tolkien");
            biblioteca.CadastrarLivro("1984", "George Orwell");
            biblioteca.CadastrarLivro("Dom Casmurro", "Machado de Assis");



            // Listar livros
            Console.WriteLine("\nLivros na biblioteca:");
            biblioteca.ListarLivros();

            // Emprestar livro
            Console.WriteLine("\nEmprestando livro '1984'...");
            biblioteca.EmprestarLivro("1984");

            // Listar livros novamente
            Console.WriteLine("\nLivros na biblioteca após empréstimo:");
            biblioteca.ListarLivros();

            // Devolver livro
            Console.WriteLine("\nDevolvendo livro '1984'...");
            biblioteca.DevolverLivro("1984");

            // Listar livros novamente
            Console.WriteLine("\nLivros na biblioteca após devolução:");
            biblioteca.ListarLivros();



            Console.ReadLine();
        }

    }

}
