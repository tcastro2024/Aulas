using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___Revisoes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Estudante estudante = new Estudante("Andre", new ContaBancaria());
           Estudante estudante1 = new Estudante("Ana", new ContaBancaria());
           Estudante estudante2 = new Estudante("Paulo", new ContaBancaria());

           List<Estudante> estudantes = new List<Estudante>();

            estudantes.Add(estudante);
            estudantes.Add(estudante1);
            estudantes.Add(estudante2);


        }
    }
}
