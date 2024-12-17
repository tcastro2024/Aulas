using Aula_22___Exercicio_3_POO.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Exercicio_3_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          
              Com recurso a métodos e lógica de programação estruturada, desenvolva o jogo
              "Adivinha o número".
              Resumo: O computador deve "pensar" num número que o utilizador tenta adivinhar.
              Descrição detalhada:
              1.1 Após cada tentativa o programa deve, caso o número não seja o pensado pelo computador, indicar se
              a solução é mais alta ou mais baixa.
              1.2 Por omissão o programa deve pensar num número entre 1 e 100.
              1.3 Por omissão o programa deve permitir 10 tentativas para adivinhar o número.


          Random rnd = new Random();

          int random = rnd.Next(1, 100);
          Console.WriteLine("Valor aleatório: " + random);
          int cont = 0;

          for(int i = 0; i < 100; i++)
          {
              Console.WriteLine("Insira a sua opção: ");
              int value = int.Parse(Console.ReadLine());

              if(cont == 10)
              {
                  Console.WriteLine("O jogo terminou o número aleatório é " + value + ".");
                  break;
              }

              if (value < random)
              {
                  Console.WriteLine("A solução é mais alta, nº inserido " + value + ".");
              }
              else if (value > random)
              {
                  Console.WriteLine("A solução é mais baixa, nº inserido " + value + ".");
              }
              else if (value == random)
              {
                  Console.WriteLine("Acertou, parabens.");
                  break;
              }

              cont++;
          }
          */

            /*
             2. Com recurso ao POO(Programação Orientada a Objetos), desenvolva um programa que leia os dados de
                um colaborador com N contratos (N fornecidos pelo utilizador). Depois, solicitar ao utilizador um mês/ano e
                mostrar qual foi o salário do colaborador nesse mês/ano.
                Descrição detalhada:
                2.1 Analisar e justificar se é utilizado ou não sobrecarga, encapsulamento, herança e interface.
                2.2 Criar a estrutura UML sem identificar o construtor, com recurso ao https://app.diagrams.net/ , Word
                ou outra ferramenta devidamente identificada no relatório.
                2.3 Desenvolver o programa a semelhança do “output” sugerido.
             */

            Console.Write("Nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Dados do colaborador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (JUNIOR / MEDIO / SENIOR): ");
            string nivel = Console.ReadLine();
            Enum.TryParse(nivel.ToUpper(), out NivelOperario nivelEnum);

            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(nomeDepartamento);
            Colaborador colaborador = new Colaborador(nome, nivelEnum, salarioBase, departamento);

            Console.Write("Quantos contratos tem este trabalhador? ");
            int qtdContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContratos; i++)
            {
                Console.WriteLine($"Digite os dados do {i}º contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                CustoHora custoHora = new CustoHora(data, valorPorHora, horas);
                colaborador.AdicionaContrato(custoHora);
            }

            Console.WriteLine();
            Console.Write("Digite o mês e o ano para calcular o valor acrescentado(MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("Nome: " + colaborador.Nome);
            Console.WriteLine("Departamento: " + colaborador.Departamento.Nome);
            Console.WriteLine("Valor acrescentado para " + mesAno + ": " + colaborador.ValorAcrescentado(ano, mes).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
