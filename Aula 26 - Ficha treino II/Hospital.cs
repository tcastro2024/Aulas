//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-12-27</date>
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
    /// <summary>
    /// Purpose: classe Hospital
    /// Created by: tcastro
    /// Created on: 27/12/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Hospital: Empresa, IEmpresa
    {
        #region Propriedades

        public string Nome { get; set; }
        public Paciente Paciente { get; set; }

        #endregion


        #region Construtores
        public Hospital() { }

        public Hospital(string parametroNome, Paciente parametroPaciente)
        {
            this.Nome = parametroNome;
            this.Paciente = parametroPaciente;
        }

        #endregion

        #region Metodos

        public double RetornaTroca(double pagamento, double preco)
        {
            if (pagamento <= 0 || preco <= 0)
                return -1;

            return pagamento - preco;
        }

        public override string ClassificaEncomendas(List<int> qtdEncomendas)
        {
            double soma = 0.0;

            if (qtdEncomendas == null)
                return null;

            soma = qtdEncomendas.Sum();

            if (soma > 20)
                return "Excelente";
            else if (soma > 10)
                return "Bom";
            else if (soma > 5)
                return "Positivo";
            else
                return "Negativo";
        }

        public double Aumenta6Perc(double preco)
        {
            if (preco <= 0)
                return preco;

            return preco + (preco * 0.06);
        }

        #endregion
    }
}
