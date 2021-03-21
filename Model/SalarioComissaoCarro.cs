using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalarioComissaoCarro
    {
        #region Propriedades
        public double carro { get; set; }
        public double comissao { get; set; }
        public double vendas { get; set; }
        public double salarioFixo { get; set; }
        public double vCustoFab { get; set; }

        public double salario = 0, porcDistri = 29, porcImpostoFab = 47, 
                      vCusto = 0, impostDistri = 0, vConsumidor = 0, valorRecebido = 0;
        #endregion

        #region
         public double calculaSalario()
        {
            this.salario = this.salarioFixo + (this.comissao * this.carro) + (this.vendas + 0.05);
            return this.salario;
        }

        public double calculaSalarioEx6()
        {
            if (this.vendas <= 150)
            {
                this.valorRecebido = this.vendas + (this.vendas * 0.03);
            }
            else
            {
                double valorAcima = (this.vendas - 1500) * 0.05;
                this.valorRecebido = this.vendas + (1500 * 0.03) + valorAcima;
            }
            return this.valorRecebido;
        }

        public double calculaImpostoDistribuidor()
        {
            this.impostDistri = (this.vCustoFab + (this.vCustoFab * this.porcDistri / 100));
            this.vCusto = this.vCustoFab + (this.vCustoFab * this.porcImpostoFab / 100);
            this.vConsumidor = this.vCustoFab + vCusto + impostDistri;
            return this.vConsumidor;
        }

        public override string ToString()
        {
            return "O salario no final do mes foi de: " + calculaSalario();
        }
        #endregion
    }

}
