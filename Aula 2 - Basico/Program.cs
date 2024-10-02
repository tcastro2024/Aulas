//-----------------------------------------------------------------
//    <copyright file="Aula_1.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-02</date>
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

namespace Aula_2___Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            //One line of coment

            /*
             * 
             * 
             * 
        
            Coment1
            Coment2
            */

            //POO average = (CT * 0,4) + (CP * 0,6)

            // int     Exemplo: idade, 1, 10, ...
            // double  Exemplo: comprimento, 25,5 m
            // string  Exemplo: "Aula POO é isto"
            // bool    Exemplo: if(ETarde) true/false

            double CT = 0.0, CP = 0.0, average = 0.0;

            Console.Write("CT: ");
            CT = double.Parse(Console.ReadLine());

            Console.Write("CP: ");
            CP = double.Parse(Console.ReadLine());

            average = (CT * 0.4) + (CP * 0.6);

            Console.WriteLine("NF: " + Math.Round(average, 2));

            while (true)
            {
                Console.Write(' ');
            }


    

                




            Console.ReadKey();
        }
    }
}
