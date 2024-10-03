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
    internal class Program
    {

        #region ZonaDeTeste
        static void Main(string[] args)
        {
            Console.WriteLine("Teste aula 3");

            //Calculadora 
            //Opções: +, -, *, /
            //Pedir apenas dois valores númericos
            //Mostrar resultado arredondado a 2 casas
            //Segundo valor é utilizado como denominador
            //Segundo valor tem ser positivo

            //Variaveis
            double primeiroValor = 0.0, segundoValor = 0.0, valorFinal = 0.0;
            string escolha = "";
            bool bIncorreto = true;

            //Ler e escrever
            Console.WriteLine("1º valor: ");
            primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("2º valor: ");
            segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação possivel (+, -, *, /): ");
            escolha = Console.ReadLine();


            if (escolha == "+")
            {
                valorFinal = primeiroValor + segundoValor;
            }
            else if (escolha == "-")
            {
                valorFinal = primeiroValor - segundoValor;
            }
            else if (escolha == "*")
            {
                valorFinal = primeiroValor * segundoValor;
            }
            else if (escolha == "/")
            {
                if(segundoValor > 0)
                {
                    valorFinal = primeiroValor / segundoValor;
                } 
                else
                {
                    bIncorreto = false;
                }
            }
            else
            {
                Console.WriteLine("Opção incorreta");
                bIncorreto = false;
            }

            if (bIncorreto)
            {
                Console.WriteLine("Resultado: {0}", valorFinal);
            }






            Console.ReadKey();
        }
        #endregion
    }
}
