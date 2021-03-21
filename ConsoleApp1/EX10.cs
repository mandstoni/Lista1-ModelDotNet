using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX10
    {
        static void Main(string[] args)
        {
            Cidade cidade = new Cidade();

            for (int i = 0; i < cidade.listHabitantes.Length; i++)
            {
                Console.Write("Informe seu salario: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                Console.Write("Informe quantos filhos tem: ");
                int filhos = int.Parse(Console.ReadLine());

                cidade.AdicionarHabitante(new Pessoa1()
                {
                    filhos = filhos,
                    salario = salario
                }, i);
            }

            Console.WriteLine("\nO maior salario foi: " + cidade.MaiorSalarioHab());
            Console.WriteLine("A media de filho foi: " + cidade.MediaNumeroDeFilhos());
            Console.WriteLine("A media de salario foi: " + cidade.MediaSalarioPopulacao());
            Console.WriteLine("A porcentagem de pessoas que ganham menos de 150 foi: " + cidade.PercentualMenor150() + "%");

            Console.ReadKey();
        } 
    }
}
