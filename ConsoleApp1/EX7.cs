using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX7
    {
        static void Main(string[] args)
        {
            double N1 = 0, N2 = 0, N3 = 0;

            Console.WriteLine("Informe o primeiro Nº: ");
            N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo Nº: ");
            N2 = double.Parse(Console.ReadLine());
            while (N1 == N2)
            {
                Console.WriteLine("O segundo numero não pode ser igual ao primeiro");
                Console.WriteLine("Informe o segundo Nº: ");
                N2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe o terceiro Nº: ");
            N3 = double.Parse(Console.ReadLine());


            while (N2 == N3 || N1 == N3)
            {
                Console.WriteLine("O terceiro numero não pode ser igual ao primeiro/segundo");
                Console.WriteLine("Informe o terceiro Nº: ");
                N3 = double.Parse(Console.ReadLine());
            }

            Numeros numero = new Numeros()
            {
                N1 = N1,
                N2 = N2,
                N3 = N3,
            };

            Console.WriteLine(numero);
            Console.ReadKey();

        }
    }
}
