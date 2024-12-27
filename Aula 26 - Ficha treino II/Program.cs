//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-12-22</date>
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

namespace Aula_26___Ficha_treino_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital("Hospital São João", new Paciente());
            Hospital hospital1 = new Hospital("Hospital Santa Maria", new Paciente());
            Hospital hospital2 = new Hospital("Hospital Dona Estefánia", new Paciente());

            List<string> hospitais = new List<string>();

            hospitais.Add(hospital.Nome);
            hospitais.Add(hospital1.Nome);
            hospitais.Add(hospital2.Nome);

            hospitais.Sort();

            foreach (string nomes in hospitais)
            {
                Console.WriteLine(nomes);
            }

            Console.ReadKey();
        }
    }
}
