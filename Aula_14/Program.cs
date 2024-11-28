using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);

            /*
            Pergunta para investigação e
            se tivessemos de colocar o símbolo €
            o que teriamos de fazer?
            Explorar a biblioteca CultureInfo e System.Text.Encoding
            Adicionalmente X-path e REGEX

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
             */
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Current balance is €{0}", ba.Balance);
           

            //Start without bebug
            //or
            Console.ReadKey();
        }
    }
}
