using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numeros
    {
        #region Propriedades 
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }

        public double maior, media;
        public int[] listNumero = new int[10];

        #endregion

        #region Metodos
        public double verificaNumeros()
        {
            if (this.N1 > this.N2 && this.N1 > this.N3)
            {
            
                return this.maior = this.N1;
            }
            else if (this.N2 > this.N1 && this.N2 > this.N3)
            {
           
                return this.maior = this.N2;
            }
            else
            {
                return this.maior = N3;
            }

        }
        public string verificaTriangulo()
        {
            if (this.N1 < (this.N2 + this.N3))
            {
                if (this.N2 < (this.N3 + this.N1))
                {
                    if (this.N3 < (this.N1 + this.N2))
                    {
                    
                       return "É um triangulo";
                    }
                    else
                    {
                     
                        return "Não é um triangulo";
                    }
                }
                else
                {
                    return "Não é um triangulo";
                }
            }
            else
            {
                return "Não é um triangulo";
            }
        }

        public decimal MediaAritmetica()
        {
            decimal soma = 0, qtd = 0;

            int inicio = 15, fim = 100;
            for (int i = inicio; i <= fim; i++)
            {
                soma += i;
                qtd++;
            }
            return soma / qtd;
        }

        public void ImprimirSequenciaDeNumeros()
        {
            for (int i = 1; i <= this.N1; i++)
            {
                Console.WriteLine("\n" + i);
            }
        }

        public void InserirNumero(int numero, int i)
        {
            listNumero[i] = numero;
        }

        public int Somar()
        {
            int soma = 0;
            for (int i = 0; i < listNumero.Length; i++)
            {
                soma = soma + listNumero[i];
            }
            return soma;
        }

        public override string ToString()
        {
    
            return "O maior numero é: " + verificaNumeros();
        }

        #endregion

    }
}
