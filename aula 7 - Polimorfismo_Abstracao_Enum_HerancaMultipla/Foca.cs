using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    //-> só é possivel ter uma classe base
    //para ter multipla herança e colocar a class Animal teria-se de transformar a classe em interface
    class Foca : Animal3Abstrato, IAnimal, IAnimal2
    {
        public override void Tipo()
        {
            Console.WriteLine("Foca move-se nadando.");
        }

        public void Mover()
        {
            Console.WriteLine("Foca move-se nadando.");
        }

        public virtual void Habitat()
        {
            Console.Write("\nOs animais têm um habitat.");
        }

        public void GetTipoAnimal()
        {
            Console.WriteLine("Mamífero.");
        }
        public void GetTipoHabitat()
        {
            Console.WriteLine("Marinho.");
        }

        public void getTipo()
        {

        }
        public void getEspecie()
        {

        }
    }
}
