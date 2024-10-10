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
//using CalcDLL; //Utilizar dll criada manualmente FORA DO PROJETO
using Usa_DLL_Aula3; //Utilizar dll criada manualmente DENTRO DO PROJETO
using System.Globalization;
using Areas; //Utilizar dll criada manualmente DENTRO DO PROJETO

namespace Aula_4___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A_LA_JAVA
            //Pessoa p = new Pessoa();
            //p.SetIdade(12);
            //Console.WriteLine("Idade: " + p.GetIdade().ToString());

            //Pessoa q = new Pessoa();
            //q.SetIdade(14);
            #endregion

            Pessoa p = new Pessoa();    //cria objeto
            Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");

            p.Idade = 23;               //set Idade
            p.Nome = "Tiago";           //set Nome
            Console.WriteLine("Nome:" + p.Nome + " Idade: " + p.Idade);    //get

            Pessoa r = new Pessoa("João", 12);
            Console.WriteLine($"Nome: {r.Nome} - Idade: {r.Idade}");

            //bool aux = r.ExistePremio(230);

            Console.WriteLine("Tot: " + Pessoa.TotObjetos.ToString());

            Console.ReadKey();
        }
    }
}
