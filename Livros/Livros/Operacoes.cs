using Livros.Domain;
using Livros.Domain.Data;
using Livros.Services;
using Livros.Operacoes;

namespace Livros.Operacoes
{
    public class Operacoes
    {
        private ILivroService livroService;
        private IAutorService autorService;

        public Operacoes(ILivroService livroService, IAutorService autorService)
        {
            this.livroService = livroService;
            this.autorService = autorService;
        }

        public void CadastrarLivro(string titulo, int autorId, int estoque)
        {
            Livro livro = new Livro
            {
                Titulo = titulo,
                AutorId = autorId,
                Estoque = estoque
            };

            livroService.CadastrarLivro(livro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        public void CadastrarAutor(string nome)
        {
            Autor autor = new Autor
            {
                Nome = nome
            };

            autorService.CadastrarAutor(autor);
            Console.WriteLine("Autor cadastrado com sucesso!");
        }

        public void AdicionarEstoque(int livroId, int quantidade)
        {
            livroService.AdicionarEstoque(livroId, quantidade);
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        public void RetirarEstoque(int livroId, int quantidade)
        {
            livroService.RetirarEstoque(livroId, quantidade);
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        public void ListarEstoque(int livroId)
        {
            int estoque = livroService.ObterEstoque(livroId);
            if (estoque >= 0)
            {
                Console.WriteLine($"Estoque do livro (ID {livroId}): {estoque}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}
