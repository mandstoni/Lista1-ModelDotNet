using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX12
    {
        static void Main(string[] args)
        {
            Numeros soma = new Numeros();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + (i + 1) + "nº: ");
                soma.InserirNumero(int.Parse(Console.ReadLine()), i);
            }

            Console.WriteLine("A soma de todos os nº foi: " + soma.Somar());
            Console.ReadKey();
        }
    }
}
