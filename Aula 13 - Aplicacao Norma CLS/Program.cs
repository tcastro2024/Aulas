using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13___Aplicacao_Norma_CLS
{
    internal class Program
    {
        [assembly: CLSCompliant(true)]
        static void Main(string[] args)
        {
            #region GET e SET A_LA_JAVA

            EmpresaLEIM empresaLEIM = new EmpresaLEIM();
            EmpresaLEIM empresaLEIM2 = new EmpresaLEIM();

            empresaLEIM.setNome("Eduardo");

            Console.WriteLine( empresaLEIM.getNome());

            #endregion


            #region Documentação CLS

            //https://learn.microsoft.com/en-us/dotnet/standard/language-independence
            //A norma CLS(Common Language Specification) é um conjunto de regras que garantem a interoperabilidade
            // entre diferentes linguagens que utilizam o.NET Framework, ou seja,
            // podemos utilizar o mesmo código para diferentes liguagens como c++ ou outras
            // que pertecem .NET
            // Seguir essas regras em  C# significa que o código será acessível
            // e utilizável por outras linguagens compatíveis com o .NET como Visual Basic entre outras

            //Indique que sua aplicação ou biblioteca segue as diretrizes da norma CLS.
            // Esse atributo pode ser aplicado no nível de assembly, classe, método, ou membro.
            // [assembly: CLSCompliant(true)]

            //Evite tipos que não são suportados em todas as linguagens.NET.Por exemplo:
            //Use int em vez de uint.
            //Evite sbyte e ushort.Prefira short e byte.


            //Com essas práticas, você pode garantir que sua biblioteca ou aplicação seja interoperável 
            // em diferentes linguagens dentro do ecossistema.NET
            #endregion

            EmpresaLEIM empresaLEIM = new EmpresaLEIM();

            Console.WriteLine( empresaLEIM.SomarLambda(2, 2));
            Console.WriteLine(empresaLEIM.Somar(2, 2));
            Console.WriteLine(empresaLEIM.SomarNaoCLS(2, 2));
            Console.WriteLine(empresaLEIM.SomarNaoCLSLambda(2, 2));

            Console.ReadKey();
        }
    }
}
