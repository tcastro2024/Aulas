using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Correcao da Ficha 
            //#region Exemplos de aplicacao 
            //Estudante estudante = new Estudante();

            ////Console.WriteLine(estudante.ObterAnoDeNascimento() );

            ////Exemplo de acesso direto ao atributo da classe abstrata
            //estudante.corDoCabeloPublic = "rosa";

            //estudante.ContaBancaria = new ContaBancaria();
            //estudante.ContaBancaria = new ContaBancaria("conta principal");

            //Console.WriteLine("Descricao conta bancaria: " + estudante.ContaBancaria.descricao);

            ////Exemplo da utilização do método/função MediaNotas
            ////dentro da classe Estudante
            //List<double> listaDeNotas = new List<double>();

            //listaDeNotas.Add(7);
            //listaDeNotas.Add(3);
            //listaDeNotas.Add(0);

            //Console.WriteLine("Média de notas: " + estudante.MediaNotas(listaDeNotas));
            //#endregion

            //#region Exercício 4

            //List<Estudante> listaDeEstudantes = new List<Estudante>();

            //int quatidadeAlunos = 0;
            //string nome;

            //Console.WriteLine("Quantidade de alunos a verificar: ");
            //quatidadeAlunos = int.Parse(Console.ReadLine());

            //for(int i = 0; i < quatidadeAlunos; i++)
            //{
            //    Console.WriteLine("Nome: ");
            //    nome = Console.ReadLine();

            //    Estudante estudante2 = new Estudante(nome, new ContaBancaria());

            //    listaDeEstudantes.Add(estudante2);
            //}

            //foreach (Estudante estudante3 in listaDeEstudantes)
            //{
            //    Console.WriteLine("Nome: " + estudante3.Nome + ", ContaBancaria: " + estudante3.ContaBancaria.descricao);
            //}

            ////ou

            //for (int i = 0; i < listaDeEstudantes.Count; i++)
            //{
            //    Console.WriteLine("Nome: " + listaDeEstudantes[i].Nome + "," +
            //        " ContaBancaria: " + listaDeEstudantes[i].ContaBancaria.descricao);
            //}

            //#region Dados diretos para teste
            ////Caso não fosse para pedir ao utilizador
            ////listaDeEstudantes.Add(new Estudante("André", new ContaBancaria("Conta corrente")));
            ////listaDeEstudantes.Add(new Estudante("Tiago", new ContaBancaria("Conta poupança")));

            ////foreach (Estudante estudante1 in listaDeEstudantes)
            ////{
            ////    Console.WriteLine("Nome: " + estudante1.Nome + ", ContaBancaria: " + estudante1.ContaBancaria.descricao);
            ////}

            //////ou

            ////for (int i = 0; i < listaDeEstudantes.Count; i++)
            ////{
            ////    Console.WriteLine("Nome: " + listaDeEstudantes[i].Nome + "," +
            ////        " ContaBancaria: " + listaDeEstudantes[i].ContaBancaria.descricao);
            ////}

            //double[] listaNotas = new double[4];
            //listaNotas[0] = 5.5;

            //#endregion

            //#endregion

            //#region Outro Exemplo 
            //Carro carro = new Carro();

            ////carro.cor = null;

            //carro.Cor = "Verde";
            //#endregion


            ////3

            //int qtd;

            //Console.WriteLine("Qtd de ph: ");
            //qtd = int.Parse(Console.ReadLine());

            //for (int i = 0; i < qtd; i++)
            //{
            //    //CWL() do ph
            //    //CRL() do ph

            //    //if - else if - (else opcional)
            //}
            ////declarar variavel media
            ////declarar variavel soma
            ////declarar variavel contador 

            //while(0 != -1)
            //{
            //    //CWL() de golos
            //    //CRL() do golos

            //    // somar o que o utilizador 
            //    // coloca

            //    //contar
            //}

            //// media = soma / contar

            ////C.WL("Resultado: " + media);
            ///

            #endregion


            /*
             * 4. Chame a classe desenvolvida
             * e crie um exemplo em que o construtor com parâmetros
             * recebe dados inseridos pelo utilizador.
             * Posteriormente escreva os dados que o utilizador inseriu.
             * Obrigatório utilizar collections para
                    adicionar e mostrar os dados. 
             */

            //Estudante
            Estudante estudante = new Estudante();
            string nome;
            Console.WriteLine("Nome: " ); //C.WL
            nome = Console.ReadLine();

           // Estudante estudante1 = new Estudante("João");

            ContaBancaria contaBancaria = new ContaBancaria();

            Estudante estudante1 = new Estudante(nome, contaBancaria);
           // Estudante estudante1 = new Estudante(nome, new ContaBancaria());

            estudante1.CordDoCabelo = "Verde";

            List<Estudante> listaEstudantes = new List<Estudante>();

            listaEstudantes.Add(estudante1 );

            foreach (Estudante estudante2 in listaEstudantes)
            {
                Console.WriteLine(estudante2.Nome);
            }

            //Console.WriteLine(listaEstudantes[0].Nome);
            //Console.WriteLine(estudante1.Nome);
            //Console.WriteLine(estudante1.CordDoCabelo);

            Console.ReadKey();
        }
    }
}
