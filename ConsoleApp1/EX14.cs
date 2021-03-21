using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX14
    {
        static void Main(string[] args)
        {
            Numeros numero = new Numeros();

            Console.WriteLine("A média foi: " + numero.MediaAritmetica());
            Console.ReadKey();
        }
    }
}
