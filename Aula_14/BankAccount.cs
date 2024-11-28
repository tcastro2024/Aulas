//-----------------------------------------------------------------
//    <copyright file="Aula_14.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-11-27</date>
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

namespace Aula_14
{
    /// <summary>
    /// Purpose: classe BankAccount
    /// Created by: tcastro
    /// Created on: 27/11/2024 16:00:46 PM
    /// <summary> Classe_Para_Testes_Unitarios </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class BankAccount
    {

        #region Attributes
        public const string DebitAmountExceedsBalanceMessage = "Debito superior ao saldo existente";
        public const string DebitAmountLessThanZeroMessage = "Debito é inferior a zero";

        private readonly string customerName;
        private double balance;
        #endregion

        #region Constructors
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }
        #endregion

        #region Properties
        public string CustomerName
        {
            get { return customerName; }
        }

        //Questão faz sentido esta propriedade não ter o método SET ?
        //Pesquisar e investigar esta questão e a resposta
        public double Balance
        {
            get { return balance; }
        }

        #endregion

        #region Methods/Functions

        public void Debit(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Montante negativo");
            }

            balance += amount;
        }
        #endregion
    }
}
