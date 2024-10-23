using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7___Polimorfismo_Abstracao_Enum_HerancaMultipla
{
    class Leao: Animal, IAnimal2
    {
        public void getTipo()
        {

        }
        public void getEspecie()
        {

        }


        public Temperatura temperatura { get; set; } = Temperatura.Media; //enum

        #region Polimorfismo sem override
        public void Tipo()
        {
            Console.WriteLine("O Leão é do tipo carnivoro.");
        }
        #endregion

        #region Polimorfismo com override
        public override void TipoOverride()
        {
            Console.WriteLine("O Leão é do tipo carnivoro.");
        }
        #endregion


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            Temperatura temperatura = Temperatura.Media;

            this.temperatura = temperatura;

            stringBuilder.Append("O Leão tem ");

            if ((int)Temperatura.Media == 1)
              stringBuilder.Append("temperatura " + this.temperatura);

            return stringBuilder.ToString();
        }
    }
}
