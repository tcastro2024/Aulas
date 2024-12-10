using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___Revisoes
{
    public class Estudante : Pessoa, IPessoa
    {
        public string Nome { get; set; } //
        public const int anoDeNascimentoDePOOLeim2425 = 2024;
        public ContaBancaria ContaBancaria { get; set; }

        //Atributos/Propridades que não devem ter o método set
        public string Id { get;  }
        // private double SaldoBancario { get;  }


        #region Contrutores
        public Estudante()
        {

        }

        public Estudante(string nome, ContaBancaria contaBancaria, string id)
        {
            this.Nome = nome;
            this.ContaBancaria = contaBancaria;
            this.Id = id;
        }

        public Estudante(string nome, ContaBancaria contaBancaria)
        {
            this.Nome = nome;
            this.ContaBancaria = contaBancaria;
            //this.Id = id;
        }

        #endregion

        #region Metodos

        //Caso de uso para retorno de lista vazias
        // public List<double> parametroListaDeNotas MediaNotas(List<double> parametroListaDeNotas)
        //if (parametroListaDeNotas == null && parametroListaDeNotas.Count <= 0)
        //    return new List<double>(); // return null

        public double MediaNotas(List<double> parametroListaDeNotas)
        {
            if (parametroListaDeNotas == null && parametroListaDeNotas.Count <= 0)
            {
                return 0.0;
            }
               

            double media;

            media = parametroListaDeNotas.Sum() / parametroListaDeNotas.Count();

            return media;
            //return parametroListaDeNotas.Average();
        }

        public int ObterAnoDeNascimento()
        {
            return anoDeNascimentoDePOOLeim2425;
        }

        public override string ClassificaAlturas(double altura)
        {
            if (altura <= 0)
                return "";

            if (altura < 1.2)
                return "Altura Baixa";
            else
                return "Altura acima de 1,2 m";
        }

        public bool AceitacaoPercursoEscolar(List<int> listaPercursoEscolar)
        {
            List<ContaBancaria> contaBancarias = new List<ContaBancaria>();
            contaBancarias[0].Nome = "LEIM2425";

            if (listaPercursoEscolar == null && listaPercursoEscolar.Count <= 0)
            {
                return false;
            }

            double somaMedias = 0.0, media;

            for (int i = 0; i < listaPercursoEscolar.Count(); i++)
            {
                somaMedias += listaPercursoEscolar[i];
            }

            media = somaMedias / listaPercursoEscolar.Count();

            //maior que 14 devolvemos um true 
            if( media > 14 )
            {
                return true;
            }

            return false;
        }

        public bool NumeroEPar(double numero)
        {
            if (numero <= 0)
                return false;

            if(numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
