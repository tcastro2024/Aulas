using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    abstract class AnimalAbstrato
    {
        public abstract void Mover();
        //public  void Mover();

        public virtual void Habitat()
        {
            Console.Write("\nOs animais têm um habitat.");
        }

    }
}
