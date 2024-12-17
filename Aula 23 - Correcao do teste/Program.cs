using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23___Correcao_do_Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 4

            Farmacia farmacia1 = new Farmacia("FarmaLEIM2425", new Cliente());
            Farmacia farmacia2 = new Farmacia("FarmaLEIM2425Pro", new Cliente());
            Farmacia farmacia3 = new Farmacia("FarmaLEIM2425Expert", new Cliente());

            List<Farmacia> farmacias = new List<Farmacia>();

            farmacias.Add(farmacia1);
            farmacias.Add(farmacia2);
            farmacias.Add(farmacia3);

            foreach(Farmacia farmacia in farmacias)
            {
                if (farmacia.NomeDaEmpresa.ToUpper().StartsWith("A") == true)
                    Console.WriteLine(farmacia.NomeDaEmpresa);
            }

            #endregion

            #region Exercício 5
            //Validações, Logica de código e  acessos (public, private, ...)
            #endregion
        }
    }
}
