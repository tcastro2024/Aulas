using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    class EstudanteLEIM
    {
        //1º opção
        public string IdAluno { get; set; }

        private string _idAluno;

        //2º opção propriedades
        public string IdAluno2
        {
            get { return _idAluno; }
            set { _idAluno = value; }
        }

        //3º A LA JAVA get e set camelCase -> Nomenclatura
        public string GetIdAluno()
        {
            return this._idAluno;
        }
        
        public void SetIdAluno(string idAlunoParametro)
        {
            this._idAluno = idAlunoParametro;
        }
    }
}
