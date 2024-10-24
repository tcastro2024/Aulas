using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    abstract class AnimalAbstrato
    {
        #region Atributos
        private int idade;
        private string nacionalidade;

        #endregion

        #region Construtores

        public AnimalAbstrato()
        {
        }

        public AnimalAbstrato(int idadeParametro)
        {
            Idade = idadeParametro;
        }

        public AnimalAbstrato(int idadeParametro, string nacionalidadeParametro)
        {
            Idade = idadeParametro;
            Nacionalidade = nacionalidadeParametro;
        }

        #endregion

        #region Propriedades
        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {

                if (value > -1)
                {
                    this.idade = value;
                }
                else
                {
                    this.idade = 0;
                }
            }
        }

        public string Nacionalidade
        {
            get
            {
                return this.nacionalidade;
            }
            set
            {
                this.nacionalidade = value;
            }
        }


        #endregion

        public abstract void Mover();
        //public  void Mover();

        public virtual void Habitat()
        {
            Console.Write("\nOs animais têm um habitat.");
        }
           
    }
}
