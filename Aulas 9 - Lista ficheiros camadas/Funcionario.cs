using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_9___Lista_ficheiros_camadas
{
    public class Funcionario: Colaborador, IColaborador
    {
        /*
         * Aplicar a interface e a classe abstrata e X
         * fazer um programa para ler os
        dados de um funcionário (nome, salário bruto e imposto).x
        Em seguida, mostrar os dados do funcionário (nome e salário líquido).
        Em seguida, aumentar o salário do funcionário com base em uma
        percentagem dada (somente o salário bruto é afetado pela
        percentagem) e mostrar novamente os dados do funcionário.
        Utilize a classe projetada abaixo.
        Adicionalmente mostre o output dos métodos implementados na
        interface e herdados da classe abstrata.
         */

        //ATRIBUTOS
        private string nome; 
        private double salarioBruto; 
        private double imposto;
        private const int anosEscolares = 20;
        private const int anoDeNascimento = 2004;

        //public const int qtdMeses = 12;

        public Funcionario()
        { 
        
        }

        public Funcionario(string parametroNome, double parametroSalarioBruto, double parametroImposto)
        {
            this.nome = parametroNome;
            this.salarioBruto = parametroSalarioBruto;
            this.imposto = parametroImposto;
        }

        //Propriedades (encapsulamento)
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }

        }

        public double SalarioBruto
        {
            get
            {
                return salarioBruto;
            }
            set
            {
                this.salarioBruto = value;
            }

        }

        public double Imposto
        {
            get
            {
                return imposto;
            }
            set
            {
                this.imposto = value;
            }

        }


        //Interface
        public int QtdAnos()
        {                   
            return anosEscolares;
        }

        public static int GetAnoNascimento()
        {
            return anoDeNascimento;
        }
        public bool ValidaTamanhoNIF(string nifParametro)
        {
            if(nifParametro.Length == 9)
                return true;
            else
                return false;
        }

        //classe abstrata Colaborador

        public override double SimulacaoAumento(double percentagemParametro)
        {
            return SalarioLiquido() + (SalarioBruto * percentagemParametro / 100);
        }
        public override string AvaliacaoDesempenho(int classificacaoParametro)
        {
            if (classificacaoParametro >= 5)
                return "Excelente";
            else if (classificacaoParametro >= 3)
                return "Bom";
            else
                return "Satisfeito";
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double percentagemParametro)
        {
            //SE UTILIZARMOS O SALARIO BRUTO
            //return SalarioBruto + ( SalarioBruto * percentagemParametro / 100);
            // return SalarioBruto += SalarioBruto * percentagemParametro / 100;

            //SE UTILIZARMOS O SALARIO LIQUIDO
            return SalarioLiquido() + (SalarioBruto * percentagemParametro / 100);
        }

    }
}
