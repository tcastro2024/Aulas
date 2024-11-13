using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_9___Lista_ficheiros_camadas
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string nome = "Tomas";
            //double salarioBruto = 6000, Imposto =1000;

            //Console.WriteLine("Nome: ");
            //nome = Console.ReadLine();

            //Funcionario funcionario = new Funcionario(nome, salarioBruto, Imposto);

            //--------------------------

            double percentagem;

            Funcionario funcionario = new Funcionario("Tomas Fernandes", 6000, 1000);
            Console.WriteLine(Funcionario.GetAnoNascimento());


            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Salário Bruto: " + funcionario.SalarioBruto);
            Console.WriteLine("Imposto: " + funcionario.Imposto);

            List<int> lista = new List<int>();
            

            Console.WriteLine("Funcionario: " + funcionario.Nome + ", " + funcionario.SalarioLiquido());

            Console.WriteLine("Percentagem do aumento de salário: ");
            percentagem = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados atualizados: " + funcionario.Nome + ",  " + funcionario.AumentarSalario(percentagem));

            
            Console.WriteLine(funcionario.AvaliacaoDesempenho(5));

            Console.ReadLine();
        }
    }
}
