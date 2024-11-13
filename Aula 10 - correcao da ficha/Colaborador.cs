using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public class Colaborador: Pessoa
    {
        public override string ClassificacaoDaAltura(double altura)
        {
            return "Altura padrão";
        }

        public override string CordDoCabelo2 { get; set; }
    }
}
