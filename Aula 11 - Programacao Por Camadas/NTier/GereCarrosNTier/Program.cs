using GereCarrosNTier.CarrosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCarrosNTier
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO NTier
            // https://imar.spaanjaars.com/416/building-layered-web-applications-with-microsoft-aspnet-20-part-1

            //BL Validações
            //DB Operações a base de dados
            //BO Representa os dados a tratar 
            //MAIN Camada de apresentação
            //ou em contexto de desenvolvimento
            //será requesitado pela camada de FE (front-end, Java/Type script, React Native, Angular)

            Carro c = new Carro();
            c.matricula = "00.00.00";

            CarroBL.CarroBL carroBL = new CarroBL.CarroBL();
           

            CarroBL.CarroBL.EstacionaCarro(c);

            Console.WriteLine("Carro Estacionado: " + CarroBL.CarroBL.EstacionaCarro(c).ToString());
            Console.ReadKey();
        }
    }
}
