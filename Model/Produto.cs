using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        #region Propriedades
        public Produto[] listProduto = new Produto[15];
        public string Codigo { get; set; }
        public decimal Preco { get; set; }
        #endregion

        #region Métodos
        public void AdicionarProduto(Produto produto, int i)
        {
            listProduto[i] = produto;
        }

        public decimal MediaDosPrecos()
        {
            decimal media = 0;
            for (int i = 0; i < listProduto.Length; i++)
            {
                media += listProduto[i].Preco;
            }
            return media / listProduto.Length;
        }

        public decimal ProdutoMaisCaro()
        {
            decimal maior = 0;
            for (int j = 0; j < listProduto.Length; j++)
            {
                if (listProduto[j].Preco >= maior)
                {
                    maior = listProduto[j].Preco;
                }
            }
            return maior;
        }

        public override string ToString()
        {
            return "Código: " + this.Codigo + "\nPreço: " + this.Preco;
        }
        #endregion
    }
}
