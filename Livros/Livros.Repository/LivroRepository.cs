// LivroRepository.cs
using System.Collections.Generic;
using Livros.Domain;
using Livros.Domain.Data;

namespace Livros.Repository
{
    public class LivroRepository
    {
        private List<Livro> livros = new List<Livro>();

        public void CadastrarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public Livro ObterLivroPorId(int id)
        {
            return livros.Find(l => l.Id == id);
        }

        public void AtualizarLivro(Livro livro)
        {
            var index = livros.FindIndex(l => l.Id == livro.Id);
            if (index != -1)
            {
                livros[index] = livro;
            }
        }
    }
}
