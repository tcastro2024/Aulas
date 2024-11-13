using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___correcao_da_ficha
{
    public class Carro: Veiculo, IVeiculo
    {

        public Carro() { }

        public override string ClassificaMovimento(int paramentroClassificacao)
        {
            return "Anda na estrada esmaga método abstracto";
        }
        public override string ClassificaMovimento2(int paramentroClassificacao)
        {
            return "Anda na estrada";
        }

        public string ClassificaCombustivel(int paramentroClassificacao)
        {
            return "gasoleo, gas, gasolina, ...";
        }
    }
}
