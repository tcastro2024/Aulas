using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    class Pessoa: AnimalAbstrato, IAnimal2, IAnimal
    {
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
    }
}
