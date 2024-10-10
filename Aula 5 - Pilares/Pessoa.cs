using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Pilares
{
    public abstract class Pessoa: IPessoa
    {
        int idade;
        string nome;
        public abstract int GetAge();

        //Interface obriga à implementação do método
        public abstract int GetIdade();

        //Respeita Interface. Método já implementado!
        public string GetNome()
        {
            return nome;
        }
        //Propriedade já vai implementada! Pode ser reescrita!
        public virtual string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Propriedade já vai implementada! Não pode ser reescrita!
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Novo método à margem do Interface
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int CalculaDiasVida(int x, int y)
        {
            return idade * 365;
        }
    }

    /// <summary>
    /// Classe que procura concretizar a classe abstrata "Pessoa"
    /// É abstrata pois ainda falta implementar o método "GetIdade"
    /// </summary>
    public abstract class User : Pessoa
    {
        string login;
        string password;
        public override int GetAge()
        {
            return Idade / 2;
        }

    }

    /// <summary>
    /// Classe que concretiza a classe abstrata "User"
    /// </summary>
    public class Guest : User
    {
        /// <summary>
        /// Método abstract de Pessoa
        /// </summary>
        /// <returns></returns>
        public override int GetAge()
        {
            return Idade;
        }

        /// <summary>
        /// Método exigido de Pessoa, pelo Interface IPessoa
        /// </summary>
        /// <returns></returns>
        public override int GetIdade()
        {
            return Idade;
        }
    }

    /// <summary>
    /// Múltipla "Herança"
    /// </summary>
    public class Condutor : Carro, IPessoa
    {
        /// <summary>
        /// Assumir a Idade do Veiculo
        /// </summary>
        /// <returns></returns>
        public int GetIdade()
        {
            return base.Ano;
        }

        /// <summary>
        /// Assumir devolver o Tipo do Veiculo
        /// </summary>
        /// <returns></returns>
        public string GetNome()
        {
            return base.Tipo;
        }

        public int Idade()
        {
            return (GetIdade());
        }

        public string Nome()
        {
            return (GetNome());
        }
    }
}
