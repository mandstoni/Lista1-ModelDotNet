using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX8
    {
        static void Main(string[] args)
        {
            int L1, L2, L3;

            Console.WriteLine("Informe o 1Nº: ");
            L1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o  2Nº: ");
            L2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o  3Nº: ");
            L3 = int.Parse(Console.ReadLine());

            Numeros lados = new Numeros()
            {
                N1 = L1,
                N2 = L2,
                N3 = L3,
            };

            Console.WriteLine(lados.verificaTriangulo());
            Console.ReadKey();
        }
    }
}
