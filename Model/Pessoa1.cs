using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa1
    {
        #region Propriedades

        public int Idade { get; set; }
        public int Dias;

        public string nome { get; set; }
        public double altura { get; set; }
        public string sexo { get; set; }
        public double peso = 0;

        public int filhos { get; set; }
        public decimal salario { get; set; }

        #endregion

        #region Métodos
        public int CalculaIdadeDias()
        {
          return  Dias = (this.Idade * 365);
        }
        public double calculaIMC()
        {
            if (this.sexo == "M")
            {
                this.peso = (72.7 * this.altura) - 58;
            }
            else
            {
                this.peso = (62.1 * this.altura) - 44.7;
            }
            return this.peso;
        }
        public override string ToString()
        {
            return "Com a sua idade você ja viveu " + CalculaIdadeDias() + " dias";
        }
        #endregion

    }
}
