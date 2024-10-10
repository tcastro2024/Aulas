//-----------------------------------------------------------------
//    <copyright file="Aula_1.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-03</date>
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

namespace Aula_3___Fundamentos
{
    public class Pessoa
    {
        //atributos da classe
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public Pessoa(string nome)
        { 
        }

        public int SomaDoisValores(int x, int y)
        {
            return x + y;
        }

        public static int SomaDoisValoresEstatico(int x, int y)
        {
            return x + y;
        }
    }
}
