using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cidade
    {
        #region Propriedades
        public Pessoa1[] listHabitantes = new Pessoa1[4];
        public decimal[] temperatura = new decimal[5];
        #endregion

        #region Métodos
        public void AdicionarHabitante(Pessoa1 pessoa, int i)
        {
            listHabitantes[i] = pessoa;
        }

        public decimal MediaSalarioPopulacao()
        {
            decimal media = 0;
            for (int i = 0; i < listHabitantes.Length; i++)
            {
                media = media + listHabitantes[i].salario;
            }
            return media / listHabitantes.Length;
        }

        public decimal MediaNumeroDeFilhos()
        {
            decimal media = 0;
            for (int i = 0; i < listHabitantes.Length; i++)
            {
                media = media + listHabitantes[i].filhos;
            }
            return media / listHabitantes.Length;
        }

        public decimal MaiorSalarioHab()
        {
            decimal maior = 0;
            for (int i = 0; i < listHabitantes.Length; i++)
            {
                if (listHabitantes[i].salario > maior)
                {
                    maior = listHabitantes[i].salario;
                }
            }
            return maior;
        }

        public decimal PercentualMenor150()
        {
            decimal menor = 0;
            for (int i = 0; i < listHabitantes.Length; i++)
            {
                if (listHabitantes[i].salario < 150)
                {
                    menor++;
                }
            }
            return menor * 100 / listHabitantes.Length;
        }

        public void AdicionarTemperatura(decimal temperaturaCidade, int i)
        {
            temperatura[i] = temperaturaCidade;
        }

        public decimal TemperaturaMedia()
        {
            decimal media = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                media = media + temperatura[i];
            }
            return media / temperatura.Length;
        }

        public string MaiorEMenorTemp()
        {
            decimal maior = 0, menor = 0;
            for (int j = 0; j <= 4; j++)
            {
                if (j == 0)
                {
                    maior = temperatura[j];
                    menor = temperatura[j];
                }
                if (temperatura[j] > maior)
                {
                    maior = temperatura[j];
                }
                if (temperatura[j] < menor)
                {
                    menor = temperatura[j];
                }
            }
            return "A maior temp foi: " + maior + " A menor temp foi: " + menor;
        }

        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
