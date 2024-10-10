//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-10</date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: tcastro
    /// Created on: 10/10/2024 16:00:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        const int N = 10;
        const int Meses = 12;
        string nome;
        int idade;

        public static int totObjetos = 0;   //atributo de classe

        int[] premios;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor
        /// </summary>
        public Pessoa()
        {
            idade = 20;
            nome = "";
            premios = new int[N];
            totObjetos++;
        }

        /// <summary>
        /// Define valores dos atributos
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        public Pessoa(int idade, string nome)
        {
            this.nome = nome;
            this.idade = idade;
            totObjetos++;
        }

        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
            totObjetos++;
        }
        public Pessoa(int idade, string nome, int totPremios)
        {
            this.nome = nome;
            this.idade = idade;
            premios = new int[totPremios];
            totObjetos++;
        }

        public Pessoa(string nomeParametro)
        {
            this.nome = nomeParametro;
        }

        //ou
        //public Pessoa(int _idade, string _nome)
        //{
        //    nome = _nome;
        //    idade = _idade;
        //}

        #endregion

        #region Properties

        /// <summary>
        /// Property Nome
        /// </summary>
        public string Nome
        {
            get
            {
                return nome;            //.ToUpper();
            }
            set
            {
                if (value.Length > 0)     //Qualquer regra
                    nome = value;
            }
        }

        /// <summary>
        /// Property Idade
        /// </summary>
        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                if (value > 0)
                    idade = value;
            }
        }

        /// <summary>
        /// Property de classe
        /// </summary>
        public static int TotObjetos
        {
            get { return totObjetos; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        #region A_LA_JAVA

        private void IsNotEmptyName(string nomeParametro)
        {
            if (nomeParametro.Length > 0)
                this.nome = nomeParametro;
            else
                this.nome = "";
        }

        public void SetNome(string nomeParametro)
        {
            IsNotEmptyName(nomeParametro);
        }





        public string GetNome()
        {
            return this.nome;
        }

        public bool SetIdade(int x)
        {
            idade = x;
            return true;
        }

        public int GetIdade()
        {
            return idade;
        }

        #endregion

        /// <summary>
        /// Procura elemento no array dos atributos
        /// </summary>
        /// <param name="valor">Valor a procurar</param>
        /// <returns>Encontrou ou não</returns>
        public bool ExistePremio(int valor)
        {
            foreach (int v in premios)
            {
                if (v == valor) return true;
            }
            return false;

        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
            totObjetos--;
        }
        #endregion

        #endregion
    }
}
