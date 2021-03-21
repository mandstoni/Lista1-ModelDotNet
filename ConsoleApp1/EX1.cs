using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX1
    {
        static void Main(string[] args)
        {
            int suaIdade = 0;
            Console.Write("Informe sua idade: ");
            suaIdade = int.Parse(Console.ReadLine());

            Pessoa1 pessoa = new Pessoa1()
            {
                Idade = suaIdade, 
            };

            Console.WriteLine(pessoa);
            Console.ReadKey();
        }
    }
}
