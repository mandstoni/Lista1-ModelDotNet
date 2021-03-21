using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX6
    {
        static void Main(string[] args)
        {
            double salarioFixo = 0, valorVenda = 0;


            Console.WriteLine("Informe salario: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da venda: ");
            valorVenda = double.Parse(Console.ReadLine());

            SalarioComissaoCarro venda = new SalarioComissaoCarro()
            {
                salarioFixo = salarioFixo,
                vendas = valorVenda,
            };


            Console.WriteLine("O valor recebido da comissao e salario foi de: " + venda.calculaSalarioEx6());
            Console.ReadKey();

        }
    }
}
