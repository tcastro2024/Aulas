using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public class Estudante : Pessoa, IEstudante
    {

        #region Atributos

        private string nome;
        public const int anoDeNascimento = 2000;
        private ContaBancaria contaBancaria;
        private string nivelDeFormacao = "Ensino Secundário"; //opcional

        #endregion

        #region Solução 1 Classe abstrata
        public override string ClassificacaoDaAltura(double altura)
        {

            //if (altura == null) opcional
            if (altura < 0)
                return "Insira uma altura valida";



            if (altura > 1.9)
                return "Muito alto";
            else if (altura > 1.6)
                return "Altura média";
            else
                return "Altura baixa";
        }
        #endregion

        #region Construtores

        public Estudante()
        {

        }

        public Estudante(string abc)
        {
            this.nome = abc;    
        }

        public Estudante(string parametroNome, ContaBancaria parametroContaBancaria)
        {
            this.Nome = parametroNome;
            this.ContaBancaria = parametroContaBancaria;
        }

        //ou

        public Estudante(string parametroNome, ContaBancaria parametroContaBancaria, string parametroCorDeCabelo)
        {
            this.Nome = parametroNome;
            this.ContaBancaria = parametroContaBancaria;
            this.corDoCabeloPublic = parametroCorDeCabelo;
            this.CordDoCabelo = parametroCorDeCabelo;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public ContaBancaria ContaBancaria
        {
            get
            {
                return this.contaBancaria;
            }
            set
            {
                this.contaBancaria = value;
            }
        }

        public override string CordDoCabelo2
        {
            get
            {
                return this.corDoCabeloPublic;
            }
            set
            {
                this.corDoCabeloPublic = value;
            }
        }

        #endregion

        #region Metodos/Funções

        public double MediaNotas(List<double> parametroListaDeNotas)
        {
            if (parametroListaDeNotas.Count > 0)
            {
                return parametroListaDeNotas.Sum() / parametroListaDeNotas.Count;
                //return parametroListaDeNotas.Average();
            }
            else
                return 0;
        }
        public int ObterAnoDeNascimento()
        {
            return anoDeNascimento;
        }

        public void AtualizaNivelDeFormacao(string parametroNivelFormacao)
        {
            if (parametroNivelFormacao != null && parametroNivelFormacao.Length > 0)
                nivelDeFormacao = parametroNivelFormacao;
        }

        #endregion

    }
}
