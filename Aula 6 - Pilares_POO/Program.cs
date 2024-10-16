﻿//-----------------------------------------------------------------
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

namespace Aula_6___Pilares_POO
{

    /// <summary>
    /// Purpose: classe Pessoa
    /// Created by: tcastro
    /// Created on: 15/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    internal class Program
    {
        static void Main(string[] args)
        {

           // Herança, polimorfismo, propriedades, virtual, override, Interface e UML


            Pessoa pessoa = new Pessoa();

            //Propriedades
            pessoa.Idade = 20;
            Console.Write($"Idade: {pessoa.Idade}");

            //Metodos
            pessoa.SetIdade(20);
            pessoa.GetIdade();


            Console.ReadKey();
        }
    }
}
