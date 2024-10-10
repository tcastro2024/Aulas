/*
*	<copyright file="Aula3.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>tcastro</author>
*   <date>10/10/2024 11:33:10 AM</date>
*	<description>
*	    Criação de uma classe calculadora simples e criação da dll
*	</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usa_DLL_Aula3
{
    /// <summary>
    /// Purpose:
    /// Created by: tcastro
    /// Created on: 10/10/2024 16:30:19 PM
    /// 
    /// Operações de uma calculadora
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Calc
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calc()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods


        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calc()
        {
        }
        #endregion

        #endregion
    }

    internal class Auxiliar
    {
        const double PI = 3.14;
    }
}
