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

namespace Aula_3___Fundamentos
{
    /// <summary>
    /// Purpose:
    /// Created by: tcastro
    /// Created on: 10/10/2024 16:00:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Funcionario
    {
        #region Atributos

        public string nome;
        public int idade;
        public double salario;

        #endregion

        #region Construtores

        public Funcionario() 
        {
        }

        public Funcionario(string nomeParametro, int idadeParametro)
        {
            this.nome = nomeParametro;
            this.idade = idadeParametro;
        }

        public Funcionario(string nomeParametro, int idadeParametro, double salarioParametro)
        {
            this.nome = nomeParametro;
            this.idade = idadeParametro;
            this.salario = salarioParametro;
        }



        #endregion

    }
}
