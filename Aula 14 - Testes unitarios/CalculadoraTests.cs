

/**
 *Unit Tests
 * tcastro
 * POO - 2024-2025
 * 
 * Test method requirements
 * - A test method must meet the following requirements:
 *-  It's decorated with the [TestMethod] attribute.
* -  It returns void.
 * - It cannot have parameters.
 * 
 * Pattern: Arrange | Act | Assert
 * Ver: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Testar classes da Calculadora
namespace Aula_14___Testes_unitarios
{
    [TestClass]
    public class CalculadoraTests
    {
        [TestMethod]
        public void Somar_DeveRetornarSomaDeDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            int resultado = calculadora.Somar(2, 3);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Subtrair_DeveRetornarDiferencaDeDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            int resultado = calculadora.Subtrair(5, 3);

            // Assert
            Assert.AreEqual(2, resultado);
        }

        [DataTestMethod]
        [DataRow(2, 3, 6)]
        [DataRow(4, 5, 20)]
        [DataRow(0, 10, 0)]
        public void Multiplicar_DeveRetornarProdutoDeDoisNumeros(int a, int b, int esperado)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            int resultado = calculadora.Multiplicar(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Dividir_DeveRetornarQuocienteDeDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Dividir(10, 2);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_DeveLancarExcecaoQuandoDivididoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            calculadora.Dividir(10, 0);
        }
    }
}