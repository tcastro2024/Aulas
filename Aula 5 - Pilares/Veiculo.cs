using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: tcastro
    /// Created on: 10/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo
    {
        #region Attributes
        int ano;
        string tipo;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            Console.WriteLine("- Mais um Veiculo");
        }

        public Veiculo(string n, int a)
        {
            //this permite chamar os atributos da classe e 
            //assumirem os valores passados  
            //por parametro nos construtores
            this.ano = ano;
            this.ano = a;
            tipo = n;
        }

        public Veiculo(int ano)
        {
            tipo = "";
            this.ano = ano;
        }

        #endregion

        #region Properties

        public int Ano
        {
            get; set;
        }

        protected string Tipo
        {
            get; set;
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Metodo para reescrever na classe filho
        /// </summary>
        /// <returns></returns>
        public virtual string GetVeiculoDetails()
        {
            return "Vei: " + tipo;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculo()
        {
        }
        #endregion

        #endregion
    }
}
