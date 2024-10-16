using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6___Pilares_POO
{
    public class Pessoa: IPessoa
    {
        #region Atributos
        int idade; // private
        string nome; // private

        #endregion


        #region Construtores

        public Pessoa() 
        { 
        }
        public Pessoa(int idadeParametro, string nomeParametro)
        {
            this.idade = idadeParametro;
            this.nome = nomeParametro;
        }

        #endregion

        #region PropriedadesEmC#
        public int Idade
        {
            get
            {
                if (idade > 0)
                    return idade;
                else
                    return 0;
            }
            set
            {
                this.idade = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;  //.ToUpper();
            }
            set
            {
                this.nome = value;
            }
        }
        #endregion

        #region Metodos A_LA_JAVA
        public int GetIdade()
        {
            return idade;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCurso()
        {
            return "LEIM";
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        #endregion

        public virtual string  ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Tiago" +
            //    "" +
            //    "" +
            //    "" +
            //    "" +
            //    "" +
            //    "Tiago" +
            //    "" +
            //    "");

            return "Nome: " + nome + "\nIdade: " + idade;
        }

        #region Destrutor

        /// <summary>
        /// Finalizes an instance of the <see cref="Pessoa"/> class.
        /// </summary>
        ~Pessoa()
        {

        }
        #endregion
    }
}
