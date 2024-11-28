
/**
 * Unit Tests with framework MSTest 
 * tcastro
 * POO - 2024-2025
 * 
 * Test method requirements
 * - A test method must meet the following requirements:
 * -  It's decorated with the [TestMethod] attribute.
 * -  It returns void.
 * - It cannot have parameters.
 * 
 * Pattern: Arrange | Act | Assert
 * See: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
 *
 * Can explore Unit Test Project, mocking e unit integration tests
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Aula_14;

namespace Aula_14___Testes_unitarios
{
    [TestClass] //Anotações A_LA_JAVA é com @
    public class BankAccountTests
    {
        #region How create unit test for C# 
        /*
         * Choose option to new project: MSTest Test Project for C#
         * 
         * ANNOTATIONS 
         * [TestClass]: Defines a class that contains tests.
         * [TestMethod]: Marks a method as an individual test.
         * [DataTestMethod]: Allows the creation of parameterized tests.
         * [DataRow]: Passes different input values to the parameterized test.
         * Assert.AreEqual(expected, actual): Verifies that the expected value matches the actual value.
         * [ExpectedException(typeof(Exception))]: Validates that the tested method throws a specific exception.
         * 
         * RUN UNIT TESTS
         * Aula 14 - Testes unitarios: Run Tests or Debug Tests
         *  
        */
        #endregion

        [TestMethod]
        public void DebitWithValidAmountUpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void DebitWhenAmountIsLessThanZeroShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void DebitWhenAmountIsMoreThanBalanceShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void DebitWhenAmountIsMoreThanBalanceShouldThrowArgumentOutOfRange_II()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);
            try
            {
                // Act
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 5, 8)]
        public void AdditionTest(int a, int b, int result)
        {
            Assert.AreEqual(result, a + b, "ERRO......");
        }
    }
}
