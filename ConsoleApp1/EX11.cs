using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX11
    {
        static void Main(string[] args)
        {
            Cidade cidade = new Cidade();
      

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe a " + (i + 1) + "ª temperatura: ");
                cidade.AdicionarTemperatura(decimal.Parse(Console.ReadLine()), i);

            }

            Console.WriteLine(cidade.MaiorEMenorTemp());
            Console.WriteLine("A media da temp foi: " + cidade.TemperaturaMedia());

            Console.ReadKey();
        }
    }
}
