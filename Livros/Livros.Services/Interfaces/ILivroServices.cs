// ILivroService.cs;
using Livros.Domain;
using Livros.Domain.Data;

namespace Livros.Services
{
    public interface ILivroService
    {
        void CadastrarLivro(Livro livro);
        Livro ObterLivroPorId(int id);
        void AtualizarLivro(Livro livro);
        void AdicionarEstoque(int livroId, int quantidade);
        void RetirarEstoque(int livroId, int quantidade);
        int ObterEstoque(int livroId);
    }
}
