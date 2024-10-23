//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-23</date>
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
    /// Purpose: classe Program teste
    /// Created by: tcastro
    /// Created on: 23/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Program
    {
        static void Main(string[] args)
        {
            //EstudanteLEIM estudanteLEIM = new EstudanteLEIM();

            ////estudanteLEIM._idAluno =  "a12345";
            ////estudanteLEIM._idAluno =  "a12345";
            ////estudanteLEIM._idAluno =  "a12345";
            ////estudanteLEIM._idAluno =  "a12345";
            ////estudanteLEIM.SetIdAluno( "a12345");




            ////Classes, Herança, Interface , Encapsulamento e propriedades

            ////Polimorfismo_Abstracao_Enum_HerancaMultipla

            //#region Polimorfismo sem override

            //AnimalAbstrato animalAbstrato = new AnimalAbstrato();

            //Animal animal = new Animal();

            //Animal cao = new Cao();
            //Animal girafa = new Girafa();
            //Animal leao = new Leao();

            ////animal.Tipo();
            ////cao.Tipo();
            ////girafa.Tipo(); 
            ////leao.Tipo();

            //#endregion

            //#region Polimorfismo com override

            //animal.TipoOverride();
            //cao.TipoOverride();
            //girafa.TipoOverride();
            //leao.TipoOverride();

            //#endregion

            ////#region enums
            ////Console.Write( leao.ToString() );
            ////#endregion


            ////// arrays, collections, operadores e exceções

            ////#region Arrays
            //int[] contaAnimais;
            //double[] comprimentoDeAnimais = { 1, 2, 0.5 };
            //string[] nomes = { "Andre", "João", "Maria" };
            //double[] notas = new double[4];

            //Array<int> arrayListPessoa = new System.Array<int>();

            //Console.WriteLine();
            //#endregion

            //#region Exceções

            //try catch
            //try
            //{
            //    int a, b;

            //    a = int.Parse(args[0]);
            //    b = int.Parse(args[1]);
            //    int soma = a + b;
            //    Console.WriteLine("{0} + {1} = {2}", a, b, soma);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("Faltam parâmetros: " + e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Erro: Não indicou dois números!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Erro: {0}.", e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finalmente...");
            //}

            ////throw
            int x = 20, y = 0, res;

            try
            {
                res = x / y;
            }
            catch (DivideByZeroException e)
            {
                throw new Exception("Nem penses dividir por Zero..." + e.Message);
            }

            //#endregion

            Console.ReadKey();
        }
    }
}
