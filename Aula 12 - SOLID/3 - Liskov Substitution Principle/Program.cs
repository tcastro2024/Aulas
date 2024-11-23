using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _3___Liskov_Substitution_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Liskov Substitution Principle
            // Substituir a classe 
            // Se algum módulo estiver autilizar uma classe Base,
            // a referência a essa classe Base poderá ser substituída
            // por uma classe Derivada sem afetar a funcionalidade do módulo.
            //
            //Resumindo nos métodos que nao queremos ou não faz sentido implementar
            //de uma interface por exemplo deve-se marcar como
            // throw new NotImplementedException();
            //
            //Devemos ter certeza de que as novas classes derivadas
            //estendem as classes base sem alterar seu comportamento.
            //Se estivermos chamando um método definido em uma classe base
            //sobre uma classe abstraída, a função deverá ser implementada corretamente
            //na classe do subtipo.

            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            Customers.Add(new Consultation());

            foreach (Customer o in Customers)
            {
                o.Add(); //throw exception for Consultation 
            }

            //Start without debugging
            //or
            Console.ReadKey(); // to see the vales on console application
        }
    }
}
