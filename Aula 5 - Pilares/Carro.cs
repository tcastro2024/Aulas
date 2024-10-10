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
    public class Carro: Veiculo
    {
        #region Attributes
        string marca;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            base.Tipo = "";
            base.Ano = DateTime.Now.Year;
            marca = "";

        }
        /// <summary>
        /// Polimorfismo no construtor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="marca"></param>
        public Carro(int a, string n, string marca)
        {
            base.Tipo = n;
            base.Ano = a;
            this.marca = marca;

        }

        /// <summary>
        /// Polimorfismo no construtor
        /// Dados passados para construtor da Super Classe: operador "base"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="marca"></param>
        public Carro(string n, int a, string marca) : base(n, a)
        {
            //base.Tipo = n;
            //base.Ano = a;
            this.marca = marca;

        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        /// <summary>
        /// Rescreve metodo da classe Pai
        /// </summary>
        /// <returns></returns>
        public override string GetVeiculoDetails()
        {
            return " Detalhes do Carro: " + base.Tipo + "Marca:" + marca + " Ano:" + Ano;
        }

        #endregion

        #region OtherMethods


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }
}
