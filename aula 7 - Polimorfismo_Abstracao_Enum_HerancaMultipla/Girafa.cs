using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    class Girafa: Animal
    {

        public void Tipo()
        {
            Console.WriteLine("A girafa é do tipo herbivoro.");
        }

        #region PolimorfismoComOverride
        public override void TipoOverride()
        {
            Console.WriteLine("O girafa é do tipo herbivoro.");
        }
        #endregion

    }
}
