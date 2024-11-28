using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13___Aplicacao_Norma_CLS
{
    
    [CLSCompliant(true)] //anotação
    public class EmpresaLEIM
    {
        //Visibilidade
        //Apenas membros públicos precisam seguir as regras da CLS.
        //Membros internos e privados podem usar tipos não compatíveis.
        public string Nome {  get; set; }
        public string nome; // Inválido

        #region  LA JAVA camelCase
        public string getNome()
        { 
            return this.nome; 
        }

        public void setNome(string nomeParametro)
        {
            this.nome = nomeParametro;
        }


        #endregion


        //Sobrecargas
        //Evitar criar métodos ou propriedades que diferenciem apenas por parâmetros
        //como out e ref, pois algumas linguagens não diferenciam essas variações.


        //Atributos de Nulo
        //Tipos anuláveis(Nullable<T> ou ?) são compatíveis,
        //mas verifique a implementação para garantir compatibilidade.

        //Use analisadores para validação
        //O compilador do .NET gera avisos(ou erros, se configurado)
        //para problemas de conformidade com CLS quando [CLSCompliant(true)] está presente.

        //Por exemplo, o código abaixo vai dar origem a um erro:

        public uint MetodoInvalido() // `uint` não é compatível com CLS
        {
            return 0;
        }

        // Documentação de exceções à CLS
        //Se algum membro da sua biblioteca não puder seguir a norma CLS,
        //adicione [CLSCompliant(false)], exemplo:
        [CLSCompliant(false)]
        public uint MetodoNaoCLS() // Este método não segue CLS
        {
            return 0;
        }

        //Mais exemplos
        public int SomarLambda(int a, int b) => a + b; //esta a ser utilizando Expressões Lambda e LINQ

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        [CLSCompliant(false)]
        public uint SomarNaoCLSLambda(uint a, uint b) => a + b; //esta a ser utilizando Expressões Lambda e LINQ

        [CLSCompliant(false)]
        public uint SomarNaoCLS(uint num1, uint num2)
        {
            return (uint)num1 + num2;
        }
    }
}
