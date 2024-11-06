using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_9___Lista_ficheiros_camadas
{
    /*
     * Defna uma classe abstrata com os seguintes métodos abstratos:
        double SimulacaoAumento(double percentagem)
        string AvalicaoDeDesempenho(int classifcacao)
     */
    public abstract class Colaborador
    {
        public abstract double SimulacaoAumento(double percentagemParametro);
       // public virtual double SimulacaoAumento(double percentagemParametro);
        public abstract string AvaliacaoDesempenho(int classificacaoParametro);

    }
}
