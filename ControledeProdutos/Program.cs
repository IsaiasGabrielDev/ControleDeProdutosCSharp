using System;
using System.Globalization;

namespace ControledeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            int opcao;
            
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantd = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();


            do
            {

                
                Console.WriteLine("\nMenu:\n1)Adicionar Produto\n2)Remover Produto\n3)Sair\n");
                Console.Write("Digite: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:

                        Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
                        int qte = int.Parse(Console.ReadLine());
                        p.AdicionarProduto(qte);

                        Console.WriteLine();
                        Console.WriteLine("Dados atualizados: " + p);
                        Console.WriteLine();


                        break;

                    case 2:
                        Console.Write("Digite o numero de produtos a ser removido do estoque: ");
                        qte = int.Parse(Console.ReadLine());
                        if (qte >= p.Quantd)
                            Console.WriteLine("A remoção não foi possivel: existem apenas {0} produtos em estoque", p.Quantd);
                        else 
                            p.RemoverProduto(qte);

                        Console.WriteLine();
                        Console.WriteLine("Dados atualizados: " + p);

                        break;

                }
            
            } while (opcao != 3);

            Console.WriteLine("Saindo...");
            return;




            

            
        }
    }
}
