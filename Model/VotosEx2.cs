using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class VotosEx2
    {
        #region Propriedades
        public double nEleitor { get; set; }
        public double votoNulo { get; set; }
        public double votoBranco { get; set; } 
        public double votoValido { get; set; }

        #endregion

        #region Metodos
        public double calculaporcVotoBranco()
        {

            return (this.votoBranco * 100) / this.nEleitor; 
        }
        public double calculaporcVotoNulo()
        {

            return (this.votoNulo * 100) / this.nEleitor;
        }
        public double calculaporcVotoValido()
        {

            return (this.votoValido * 100) / this.nEleitor;
        }

        public override string ToString()
        {
            return  "Votos em branco: " + calculaporcVotoBranco() + " % e" +
                    " Votos Nulos: " + calculaporcVotoNulo() + "% e " +
                    " Votos validos: " + calculaporcVotoValido() + "%";
        }
        #endregion
    }
}
