//-----------------------------------------------------------------
//    <copyright file="Aula_1.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-09-26</date>
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

namespace Aula_1___Basico
{
    /*
      * LEIM: POO
      * tcastro
      * 
      * Soluções e Projetos
      * Wizards
      * Regiões
      * Documentação de Código
    * */
    internal class Program
    {
        #region ZonaDeTeste 
        static void Main(string[] args)
        {
            //Criar Soluções e Projetos
            Console.WriteLine("Hello world!");

            double CT, CP, NF;

            Console.Write("\nInsira a nota de Componente Teórica (CT): ");
            CT = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a nota de Componente Prática (CP): ");
            CP = double.Parse(Console.ReadLine());

            // Calcular a média final (NF) com ponderações: 40% CT e 60% CP
            NF = (CT * 0.4) + (CP * 0.6);

            Console.WriteLine("\nA nota de CT é {0:F2} e de CP {1:F2}, dando uma média final da UC de POO igual a {2:F2}", CT, CP, NF);

            Console.ReadKey();
        }
        #endregion
    }
}
