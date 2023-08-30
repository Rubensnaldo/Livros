// LivroService.cs
using Livros.Domain;
using Livros.Domain.Data;
using Livros.Repository;

namespace Livros.Services
{
    public class LivroService : ILivroService
    {
        private LivroRepository livroRepository = new LivroRepository();

        public void CadastrarLivro(Livro livro)
        {
            livroRepository.CadastrarLivro(livro);
        }

        public Livro ObterLivroPorId(int id)
        {
            return livroRepository.ObterLivroPorId(id);
        }

        public void AtualizarLivro(Livro livro)
        {
            livroRepository.AtualizarLivro(livro);
        }

        public void AdicionarEstoque(int livroId, int quantidade)
        {
            var livro = livroRepository.ObterLivroPorId(livroId);
            if (livro != null && quantidade > 0)
            {
                livro.Estoque += quantidade;
                livroRepository.AtualizarLivro(livro);
            }
        }

        public void RetirarEstoque(int livroId, int quantidade)
        {
            var livro = livroRepository.ObterLivroPorId(livroId);
            if (livro != null && quantidade > 0 && livro.Estoque >= quantidade)
            {
                livro.Estoque -= quantidade;
                livroRepository.AtualizarLivro(livro);
            }
        }

        public int ObterEstoque(int livroId)
        {
            var livro = livroRepository.ObterLivroPorId(livroId);
            return livro != null ? livro.Estoque : -1;
        }
    }
}


