using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarUm_Editora
{
    class Editora
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public string WhatsApp { get; set; }

        private int quantidadeLivros = 0;
        public Livro[] Livros { get; set; } = new Livro[10];
        public void RegistrarLivro(Livro livro)
        {
            if (this.quantidadeLivros < 10)
                Livros[this.quantidadeLivros++] = livro;
        }
    }
}
