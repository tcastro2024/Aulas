using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Pilares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polimorfismo

            //Polimorfismo: "Overloading"
            Veiculo v = new Veiculo();
            Veiculo v1 = new Veiculo(123);

            //Polimorfismo: "Overriding"
            Console.WriteLine("Veiculo: " + v.ToString());

            #endregion


            #region Herança
            Console.WriteLine("Heranças...");
            Carro c = new Carro();

            Carro c1 = new Carro("Carro", 123, "ford");

            // GetVeiculoDetails é método do objeto Carro ou Veiculo?
            Console.WriteLine(c1.GetVeiculoDetails());

            //Cria um carro ou um veículo?
            Veiculo v3 = new Carro();
            Console.WriteLine(v3.GetVeiculoDetails());

            #endregion


            #region Abstração

            Console.WriteLine("Abstração...");
            //Pessoa p = new Pessoa();  //não pode instanciar pois é abstrata
            //User u = new User();      //não pode instanciar pois é abstrata
            Guest g = new Guest();      //pode instanciar pois Guest é concreta
            Console.WriteLine("Idade: " + g.GetAge().ToString());

            #endregion

            #region Multipla Herança

            Condutor cond = new Condutor();
            cond.Ano = DateTime.Now.Year;
            //cond.Idade = 24;
            //cond.Nome = "Manuel";

            #endregion

            Console.ReadKey();

        }
    }
}
