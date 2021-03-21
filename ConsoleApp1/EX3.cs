using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX3
    {
        static void Main(string[] args)
        {
            double vCustoFab;
         
            Console.WriteLine("Informe o valor de fabrica: ");
            vCustoFab = double.Parse(Console.ReadLine());

            SalarioComissaoCarro carro = new SalarioComissaoCarro()
            {
                vCustoFab = vCustoFab
            };
            Console.WriteLine("O valor do consumidor é " + carro.calculaImpostoDistribuidor());
            Console.ReadKey();
        }
    }
}
