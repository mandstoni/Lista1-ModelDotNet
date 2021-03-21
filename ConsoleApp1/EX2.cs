using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EX2
    {
        static void Main(string[] args) {

            double nEleitor, votoBranco, votoNulo, votoValido;

            Console.WriteLine("Informe todos os Eleitores da cidade: ");
            nEleitor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto em branco: ");
            votoBranco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto nulo: ");
            votoNulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto validos: ");
            votoValido = double.Parse(Console.ReadLine());

            VotosEx2 votos = new VotosEx2()
            {
                votoValido = votoValido,
                votoBranco = votoBranco,
                votoNulo = votoNulo,
                nEleitor = nEleitor,
            };

            Console.WriteLine(votos);
            Console.ReadKey();

        }

    }
}