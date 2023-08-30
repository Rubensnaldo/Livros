// IAutorService.cs
using Livros.Domain;
using Livros.Domain.Data;

namespace Livros.Services
{
    public interface IAutorService
    {
        void CadastrarAutor(Autor autor);
        Autor ObterAutorPorId(int id);
        void AtualizarAutor(Autor autor);
    }
}

