using Aula_21___Execoes_II.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Execoes_II.Entities
{
    // Classe Account
    class Account
    {
        public int Number { get; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number <= 0)
            {
                throw new DomainException("1003"); // Código para número de conta inválido
            }
            if (string.IsNullOrWhiteSpace(holder))
            {
                throw new DomainException("1004"); // Código para nome vazio
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("1001"); // Código para limite excedido
            }
            if (amount > Balance)
            {
                throw new DomainException("1002"); // Código para saldo insuficiente
            }

            Balance -= amount;
        }
    }
}
