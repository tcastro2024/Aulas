using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_9___Lista_ficheiros_camadas
{
    public class Funcionario: Colaborador, IColaborador
    {

        public Funcionario()
        { 
        
        }

        //Interface
        public int QtdAnos()
        {
            return 0;
        }
        public bool ValidaTamanhoNIF(string nifParametro)
        {
            return true;
        }

        //classe abstrata Colaborador

        public override  double SimulacaoAumento(double percentagemParametro)
        {
            return 0.0;
        }
        public override string AvaliacaoDesempenho(int classificacaoParametro)
        {
            return "teste";
        }


    }
}
