using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX13
    {
        static void Main(string[] args)
        {
            Numeros numero = new Numeros();

            Console.Write("Informe um numero:");
            numero.N1 = int.Parse(Console.ReadLine());

            while (numero.N1 == 0)
            {
                Console.WriteLine("O numero tem que ser maior que ZERO!");
                Console.Write("Informe um numero:");
                numero.N1 = int.Parse(Console.ReadLine());
            }

            numero.ImprimirSequenciaDeNumeros();
            Console.ReadKey();
        }
    }
}
