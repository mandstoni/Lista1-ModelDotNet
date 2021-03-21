using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX9

    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Informe o preço do " + (i + 1) + "º produto: ");
                decimal precoProduto = decimal.Parse(Console.ReadLine());

                Console.Write("Informe o código do produto: ");
                string codigoProduto = Console.ReadLine();

                produto.AdicionarProduto(new Produto()
                {
                    Codigo = codigoProduto,
                    Preco = precoProduto
                }, i);
            }

            Console.WriteLine("produto mais cara custa: " + produto.MediaDosPrecos());
            Console.WriteLine("A media de preço foi: " + produto.ProdutoMaisCaro());
            Console.ReadKey();
        }
    }
}
