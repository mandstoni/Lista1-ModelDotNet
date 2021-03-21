using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX5
    {
        static void Main(string[] args)
        {
            string sexo, nome;
            double altura = 0;

            Console.WriteLine("Informe seu nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Informe sua altura (por exemplo: 1,57): ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo (F ou M):  ");
            sexo = (Console.ReadLine().ToUpper());

            Pessoa1 pessoaIMC = new Pessoa1()
            {
                altura = altura,
                nome = nome,
                sexo = sexo,
            };

            Console.WriteLine("o seu peso ideal é: " + pessoaIMC.calculaIMC());
            Console.ReadKey();
        }
    }
}
