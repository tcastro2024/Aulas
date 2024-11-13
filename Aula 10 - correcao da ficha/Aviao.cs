using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public class Aviao: Veiculo, IVeiculo
    {

        public override string ClassificaMovimento(int paramentroClassificacao)
        {
            return "Anda na ar esmaga método abstracto";
        }

        public string ClassificaCombustivel(int paramentroClassificacao)
        {
            return "gasoleo, gasolina, ...";
        }
    }
}
