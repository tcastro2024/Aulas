using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3___Fundamentos
{
    internal class Pessoa
    {
        //atributos da classe
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int SomaDoisValores(int x, int y)
        {
            return x + y;
        }

        public static int SomaDoisValoresEstatico(int x, int y)
        {
            return x + y;
        }
    }
}
