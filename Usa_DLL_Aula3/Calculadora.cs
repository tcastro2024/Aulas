/*
*	<copyright file="Aula3.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>tcastro</author>
*   <date>08/10/2024 11:33:10 AM</date>
*	<description>
*	    Criação de uma classe calculadora simples e criação da dll
*	</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Usa_DLL_Aula3
{
    /// <summary>
    /// Purpose: Suportar métodos de uma calculadora
    /// Created by: tcastro
    /// Created on:08/10/2024 11:33:10 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calculadora
    {
        #region Attributes
        #endregion

        #region Methods
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calculadora() 
        { 
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Calcula a Soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public int SomaDoisValores(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Incrementa o valor numa unidade....
        /// </summary>
        /// <param name="k">Valor a incrementar</param>
        /// <returns></returns>
        public static int Incrementa(int k)
        {
            if (k < 9) ++k; //regra de negócio
            return k;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calculadora()
        {
        }
        #endregion
    }
}
