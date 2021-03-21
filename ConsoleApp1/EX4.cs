using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX4
    {
        static void Main(string[] args)
        {
            double vendas, salarioFixo, comissao;
            int carro;

            Console.WriteLine("Informe a quantidade de carro vendidos: ");
            carro = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por carro vendido: ");
            comissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu salario: ");
            salarioFixo = double.Parse(Console.ReadLine());

            SalarioComissaoCarro salarioCarro = new SalarioComissaoCarro()
            {
                carro = carro,
                comissao = comissao,
                vendas = vendas,
                salarioFixo = salarioFixo,
            };
            Console.WriteLine(salarioCarro);
            Console.ReadKey();
        }
    }
}
