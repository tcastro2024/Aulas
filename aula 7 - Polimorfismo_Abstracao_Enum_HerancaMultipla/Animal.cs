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

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    /// <summary>
    /// Purpose: classe Pessoa
    /// Created by: tcastro
    /// Created on: 15/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Animal: AnimalAbstrato, IAnimal
    {
        #region PolimorfismoSemOverride
        public void Tipo()
        {
            Console.WriteLine("Animal têm um tipo.");
        }
        #endregion

        #region PolimorfismoComOverride
        
        public virtual void TipoOverride()
        {
            Console.WriteLine("Animal têm um tipo.");
        }

        public override void Mover() //abstrato
        {
            Console.WriteLine("Voar");
        }

        public void GetTipoAnimal()
        {

        }
        public void GetTipoHabitat()
        {

        }
        #endregion


    }
}
