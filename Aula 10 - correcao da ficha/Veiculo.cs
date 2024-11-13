using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public abstract class Veiculo
    {
        private string TipoMovimento {  get; set; }

        private string cor;
        //public string cor;

        public string Cor
        {
            get { return cor; }
            set 
            {
                if (NaoEVazio(this.cor))
                {
                    cor = value;
                }
                else
                    cor = "Preto";
            }
        }

        // A_LA_JAVA

        /// <summary>
        /// Sets the cor.  birthday
        /// </summary>
        /// <param name="parametroCor">The parametro cor.</param>
        public void setCor(string parametroCor)
        {
            if (NaoEVazio(parametroCor))
            {
                cor = parametroCor;
            }
            else
                cor = "Preto";
        }

        private bool NaoEVazio(string cor)
        {
            return cor.Length > 0;
        }


        public abstract string ClassificaMovimento(int paramentroClassificacao);
        public virtual string ClassificaMovimento2(int paramentroClassificacao)
        {
            return "Padrão";
        }

    }
}
