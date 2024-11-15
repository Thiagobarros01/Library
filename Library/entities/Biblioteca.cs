using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.entities {
    class Biblioteca {

        private List<Livro> livros = new List<Livro>();

        // Adiciona um livro à biblioteca
        public void CadastrarLivro(string titulo, string autor) {
            var livro = new Livro(titulo, autor);
            livros.Add(livro);
            Console.WriteLine($"Livro '{titulo}' cadastrado com sucesso!");
        }

        // Busca um livro por título utilizando LINQ
        public Livro BuscarPorTitulo(string titulo) {
            return livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        // Lista todos os livros disponíveis
        public void ListarLivros() {
            if (livros.Count == 0) {
                Console.WriteLine("Não há livros cadastrados.");
                return;
            }

            foreach (var livro in livros) {
                string status = livro.Emprestado ? "Emprestado" : "Disponível";
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Status: {status}");
            }
        }

        // Realiza o empréstimo de um livro
        public void EmprestarLivro(string titulo) {
            var livro = BuscarPorTitulo(titulo);
            if (livro != null && !livro.Emprestado) {
                livro.Emprestado = true;
                Console.WriteLine($"O livro '{titulo}' foi emprestado com sucesso!");
            }
            else if (livro != null && livro.Emprestado) {
                Console.WriteLine($"O livro '{titulo}' já está emprestado.");
            }
            else {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        // Realiza a devolução de um livro
        public void DevolverLivro(string titulo) {
            var livro = BuscarPorTitulo(titulo);
            if (livro != null && livro.Emprestado) {
                livro.Emprestado = false;
                Console.WriteLine($"O livro '{titulo}' foi devolvido com sucesso!");
            }
            else if (livro != null && !livro.Emprestado) {
                Console.WriteLine($"O livro '{titulo}' não está emprestado.");
            }
            else {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }

}

