// AutorService.cs

using Livros.Domain.Data;
using Livros.Repository;

namespace Livros.Services
{
    public class AutorService : IAutorService
    {
        private AutorRepository autorRepository = new AutorRepository();

        public void CadastrarAutor(Autor autor)
        {
            autorRepository.CadastrarAutor(autor);
        }

        public Autor ObterAutorPorId(int id)
        {
            return autorRepository.ObterAutorPorId(id);
        }

        public void AtualizarAutor(Autor autor)
        {
            autorRepository.AtualizarAutor(autor);
        }
    }
}

