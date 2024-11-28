using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14___Testes_unitarios
{
    public class Calculadora
    {
        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;

        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominador não pode ser zero.");
            return (double)a / b;
        }
    }
}
