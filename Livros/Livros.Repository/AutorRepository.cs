// AutorRepository.cs
using System.Collections.Generic;
using Livros.Domain;
using Livros.Domain.Data;

namespace Livros.Repository
{
    public class AutorRepository
    {
        private List<Autor> autores = new List<Autor>();

        public void CadastrarAutor(Autor autor)
        {
            autores.Add(autor);
        }

        public Autor ObterAutorPorId(int id)
        {
            return autores.Find(a => a.Id == id);
        }

        public void AtualizarAutor(Autor autor)
        {
            var index = autores.FindIndex(a => a.Id == autor.Id);
            if (index != -1)
            {
                autores[index] = autor;
            }
        }
    }
}
