using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6___Pilares_POO
{
    //herança
    public class Colaborador: Pessoa
    {
        #region Atributos
        double salario;
        #endregion

        #region Contrutores
        //Herança

        /// <summary>
        /// Initializes a new instance of the <see cref="Colaborador"/> class.
        /// Poliformismo da utilização do contrutor da pessoa na classe colaborador
        /// </summary>
        /// <param name="salario">The salario.</param>
        /// <param name="idadeParametro">The idade parametro.</param>
        /// <param name="nomeParametro">The nome parametro.</param>
        public Colaborador(double salario, int idadeParametro, string nomeParametro) : base( idadeParametro, nomeParametro )
        {
            this.salario = salario;
            base.Idade = idadeParametro;
            base.Nome = nomeParametro;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Colaborador"/> class.
        /// </summary>
        /// <param name="salario">The salario.</param>
        /// <param name="nomeParametro">The nome parametro.</param>
        /// <param name="idadeParametro">The idade parametro.</param>
        public Colaborador(double salario, string nomeParametro, int idadeParametro)
        {
            this.salario = salario;
            this.Nome = nomeParametro;
            this.Idade = idadeParametro;
        }
        #endregion

        public override string ToString()
        {
            return "Nome: " + base.Nome 
                + "\nIdade: "+ base.Idade
                + "\nSalario: " + this.salario.ToString();
        }

    }
}
