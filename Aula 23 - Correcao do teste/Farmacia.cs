//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-12-17</date>
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

namespace ConsoleApp1
{
    #region Exercício 3
    public class Farmacia: Empresa, IEmpresa
    {
        #region Propriedades e atributos
        public string NomeDaEmpresa { get; set; }
        public const int AnoDeCriacao = 2024;
        public Cliente Cliente { get; set; }
        #endregion

        #region Construtores

        public Farmacia() 
        {

        }

        public Farmacia(string nomeParametro, Cliente clinteParametro)
        {
            this.NomeDaEmpresa = nomeParametro;
            this.Cliente = clinteParametro;
        }

        #endregion


        #region Metodos

        public string Localizacao(string medicamento)
        {
            if (medicamento == null && medicamento == "" && medicamento.Length <= 0)
                return "medicamento invalido";

            if (medicamento.ToUpper() == "BENURON")
                return "X8-12";
            else if (medicamento.ToUpper() == "BRUFEN")
                return "X5-34";
            else
                return "Localização inexistente";
        }

        public int RetornaAnoDeCriacao()
        {
            return AnoDeCriacao;
        }

        public double DevolverTroco(double preco, double pagamento)
        {
            if(preco <= 0.0 || pagamento <= 0.0)    
                return 0;
            else if (preco > pagamento)
                return 0;
            else
            {
                double troco = 0;
                troco = pagamento - preco;
                return troco;
            }    
        }

        public bool VerificaValor(List<double> lista, double valor)
        {
            if (lista == null || lista.Count == 0) 
                return false;

            for (int i = 0; i < lista.Count(); i++)
            {
                if(lista[i] == valor)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public override bool VerificaPar(List<int> lista)
        {
            if(lista == null || lista.Count == 0) 
                return false;

            int soma = lista.Sum();

            if (soma % 2 == 0)
                return true;
            else
                return false;
        }

        #endregion
    }

    #endregion
}
