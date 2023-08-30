using System;
using Livros.Domain;
using Livros.Domain.Data;
using Livros.Services;

namespace Livros
{
    class Program
    {
        static void Main(string[] args)
        {
            ILivroService livroService = new LivroService();
            IAutorService autorService = new AutorService();

            int opcao;

            do
            {
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Cadastrar Autor");
                Console.WriteLine("3 - Adicionar Estoque");
                Console.WriteLine("4 - Retirar Estoque");
                Console.WriteLine("5 - Listar Estoque");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarLivro(livroService);
                        break;
                    case 2:
                        CadastrarAutor(autorService);
                        break;
                    case 3:
                        AdicionarEstoque(livroService);
                        break;
                    case 4:
                        RetirarEstoque(livroService);
                        break;
                    case 5:
                        ListarEstoque(livroService);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 0);
        }

        static void CadastrarLivro(ILivroService livroService)
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o ID do autor: ");
            int autorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Livro livro = new Livro
            {
                Titulo = titulo,
                AutorId = autorId,
                Estoque = estoque
            };

            livroService.CadastrarLivro(livro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        static void CadastrarAutor(IAutorService autorService)
        {
            Console.Write("Digite o nome do autor: ");
            string nome = Console.ReadLine();

            Autor autor = new Autor
            {
                Nome = nome
            };

             Console.WriteLine("Autor cadastrado com sucesso!");
        }

        static void AdicionarEstoque(ILivroService livroService)
        {
            Console.Write("Digite o ID do livro: ");
            int livroId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            livroService.AdicionarEstoque(livroId, quantidade);
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        static void RetirarEstoque(ILivroService livroService)
        {
            Console.Write("Digite o ID do livro: ");
            int livroId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade a ser retirada do estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            livroService.RetirarEstoque(livroId, quantidade);
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        static void ListarEstoque(ILivroService livroService)
        {
            Console.Write("Digite o ID do livro: ");
            int livroId = Convert.ToInt32(Console.ReadLine());

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

