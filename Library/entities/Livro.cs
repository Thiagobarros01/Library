﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.entities {
    class Livro {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Emprestado { get; set; }

        public Livro(string titulo, string autor) {
            Titulo = titulo;
            Autor = autor;
            Emprestado = false;
        }
    }
}
