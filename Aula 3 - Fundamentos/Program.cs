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
using System.Threading;
using System.Threading.Tasks;
//using CalcDLL; //Utilizar dll criada manualmente FORA DO PROJETO
using Usa_DLL_Aula3; //Utilizar dll criada manualmente DENTRO DO PROJETO
using System.Globalization; 
using Areas; //Utilizar dll criada manualmente DENTRO DO PROJETO


namespace Aula_3___Fundamentos
{
    /// <summary>
    /// Class para testes
    /// </summary>
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region ZonaDeTeste
            AreasGeometricas areas = new AreasGeometricas();

            int incrementa = 4;
            int incrementaSegundoParametro = 8;
            Pessoa pessoa = new Pessoa("Teste");

            //Objeto pessoa da classe Pessoa
            pessoa.SomaDoisValores(incrementa, incrementaSegundoParametro);

            //Classe Pessoa utiliza método estático SomaDoisValoresEstatico
            Pessoa.SomaDoisValoresEstatico(incrementa, incrementaSegundoParametro);



            //Calculadora calculadora = new Calculadora();

            //Console.Write(calculadora.SomaDoisValores(4, 8));

            //Console.Write("\n {0}", Calculadora.Incrementa(incrementa));


            //Console.Write("Teste aula 3\n");

            //Calc calc = new Calc();

            //Console.WriteLine("{0} + {1} = {2}", 2, 2, calc.Soma(2, 2));


            //Calculadora calculadora = new Calculadora();

            //Console.WriteLine("{0} + {1} = {2}", 2, 2, calculadora.SomaDoisValores(2, 2));

            //string medida;
            //double medidaFracionaria;
            //bool   aux = false;



            //Console.Write("Valor: ");
            //medida = Console.ReadLine();
            //aux = double.TryParse(medida, out medidaFracionaria); //-> sistema operativo espera uma vírgula em vez de ponto

            //// Utilizar CultureInfo.InvariantCulture para garantir que o ponto seja aceite como separador decimal
            //// aux = double.TryParse(medida, NumberStyles.Any, CultureInfo.InvariantCulture, out medidaFracionaria);

            //medida = medida.Replace(',', '.'); // Substitui vírgula por ponto
            ////aux = double.TryParse(medida, NumberStyles.Any, CultureInfo.InvariantCulture, out medidaFracionaria);


            ////Console.Write("\nEstudo do Try Parse: " + aux);
            ////Console.Write("\nMedida convertida: " + medidaFracionaria);

            //Calculadora 
            //Opções: +, -, *, /
            //Pedir apenas dois valores númericos
            //Mostrar resultado arredondado a 2 casas
            //Segundo valor é utilizado como denominador
            //Segundo valor tem ser positivo

            //Variaveis
            //double primeiroValor = 0.0, segundoValor = 0.0, valorFinal = 0.0;
            //string escolha = "", segundoValorTexto = "";
            //bool   bIncorreto = true;
            //int    idade = 0;

            ////Ler e escrever
            //Console.Write("\n1º valor: ");
            //primeiroValor = double.Parse(Console.ReadLine());



            ////throw new Exception(" ");

            //try
            //{
            //    Console.Write("\n2º valor: ");
            //    segundoValor = double.Parse(Console.ReadLine());

            //    // Utilizar CultureInfo.InvariantCulture para garantir que o ponto seja aceite como separador decimal
            //     aux = double.TryParse(segundoValorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out segundoValor);

            //    idade = 20;
            //    aux = int.TryParse(segundoValorTexto,  out idade);




            //    //if (segundoValor < 0)
            //    //{
            //    //    bIncorreto = false;
            //    //}

            //    Console.Write("\nEscolha a operação possivel (+, -, *, /): ");
            //    escolha = Console.ReadLine();

            //    if (bIncorreto == false)
            //    {
            //        Console.WriteLine("O denominador têm de ser superior a 0");
            //    }
            //    else if (escolha == "+")
            //    {
            //        valorFinal = primeiroValor + segundoValor;
            //    }
            //    else if (escolha == "-")
            //    {
            //        valorFinal = primeiroValor - segundoValor;
            //    }
            //    else if (escolha == "*")
            //    {
            //        valorFinal = primeiroValor * segundoValor;
            //    }
            //    else if (escolha == "/")
            //    {
            //        valorFinal = primeiroValor / segundoValor;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opção incorreta");
            //        bIncorreto = false;
            //    }

            //    if (bIncorreto)
            //    {
            //        Console.WriteLine("Resultado: {0}", valorFinal);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    //Console.WriteLine("O erro pode ser, denominador igual 0, entre outras possibilidades.");
            //}

            ///*

            //string s;
            //s = Console.ReadLine();
            //double  a = double.Parse(s);

            ////a = double.Parse(Console.ReadLine());

            //bool aux = double.TryParse(Console.ReadLine(), out a);

            //int x = int.Parse(Console.ReadLine());
            ////int x = Convert.ToInt32(Console.ReadLine());

            //x=Calculadora.Inc(x);

            //Console.WriteLine("Valor lido {0}", x.ToString());

            //#region Interpolação de Strings >= c#6.0
            //string name = "Benfica";
            //var date = (DateTime.Now).AddDays(-1);
            //Console.WriteLine("Viva, o {0} perdeu ontem, {1}! são neste momento: {2:HH:mm}.", name, date.DayOfWeek, DateTime.Now);
            //// String interpolation:
            //Console.WriteLine($"Hello, {name}! Yesterday, {date.DayOfWeek}, we loose!  {date:HH:mm} now.");
            //#endregion

            // */

            #endregion

            #region Teste da classe Funcionario

            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Tiago";
            funcionario.idade = 40;
            
            Console.Write("\n1º Exemplo, Nome: {0}, Idade: {1}", funcionario.nome, funcionario.idade);

            Funcionario funcionario1 = new Funcionario("Paulo", 45, 900.6);

            Console.Write("\n1º Exemplo, Nome: {0}, Idade: {1} e Salário: {2}", funcionario1.nome, funcionario1.idade, funcionario1.salario);

            #endregion

            Console.ReadKey();
        }
        



        
    }
}
