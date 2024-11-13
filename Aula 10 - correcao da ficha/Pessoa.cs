using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public abstract class Pessoa
    {
        #region Solucao 1 Recomendado
        private string corDoCabelo;

        public string CordDoCabelo
        {
            get
            {
                return this.corDoCabelo;
            }
            set
            {
                this.corDoCabelo = value;
            }
        }



        //Não pode ter implementação
        public abstract string ClassificacaoDaAltura(double altura);





        //Pode ter implementação mas tem de se herdar e posteriormente
        // na classe que herda colocar override em vez de virtual
        // public override string ClassificacaoDaAlturaVirtual(double altura)
        public virtual string ClassificacaoDaAlturaVirtual(double altura)
        {
            return "Altura genérica!";
        }

        #endregion

        #region Solucao 2 Nao recomendado

        // Deve se delegar a implementação dos métodos e propriedades 
        // nas classes que herdam por norma
        // como o atibuto está public pode se ter acesso direto
        // e ter compotamentos indesejados 

        public string corDoCabeloPublic;

        //Pode se criar Propriedades abstratas sem corpo 
        //mas não podemos aplicar os atributos
        //obriga que a classe que herda faça essa parte
        public abstract string CordDoCabelo2 { get; set; }

       

        public string ClassificacaoDaAlturaSemAbstract(double altura)
        {
            if (altura > 1.8)
                return "Altura alta";
            else if(altura > 1.5)
                return "Altura baixa";
            else
                return "Altura padrão";
        }

        #endregion
    }
}
