//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-23</date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    /// <summary>
    /// Purpose: classe Pessoa
    /// Created by: tcastro
    /// Created on: 23/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Pessoa : AnimalAbstrato, IAnimal2, IAnimal
    {
        #region Atributos

        int id;
        string nome;

        Cao cao;

        #endregion


        #region Metodos

        #region Construtores

        //public Pessoa(string nomeParametro, int idade) :  base(idade)
        public Pessoa(string nomeParametro, int idade) :  base(idade)
        {
            this.Nome = nomeParametro;
           // this.Idade = idade;
        }

        public Pessoa(int idParametro, string nomeParametro, int idade, string nacionalidade) : base(idade, nacionalidade)
        {
            this.Id = idParametro;
            this.Nome = nomeParametro;
            this.Idade = idade;
            this.Nacionalidade = nacionalidade;
        }

        public Pessoa(int id, int idade) : base(idade)
        {
            this.Id = id;
            this.Idade= idade;
        }

        public Pessoa(int id)
        {
            this.Id = id;
        }

        public Pessoa(int id, Cao cao)
        {
            this.Id = id;
            this.Cao = cao; 
        }

        #endregion

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public Cao Cao
        {
            get
            {
                return cao;
            }
            set
            {
                this.cao = value;
            }
        }

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


        public void GetTipoAnimal()
        {

        }
        public void GetTipoHabitat()
        {

        }

        public override void Mover()
        {

        }

        public void getTipo()
        {

        }

        public void getEspecie()
        {

        }

        public string ToString()
        {
            return $"\nId: {Id}, Nome: {Nome}, Idade: {Idade}, Nacionalidade: {Nacionalidade}";
        }

        #endregion
    }
}
