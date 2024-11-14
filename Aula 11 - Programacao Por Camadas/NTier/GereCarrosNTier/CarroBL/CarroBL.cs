using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCarrosNTier.CarroBL
{
    class CarroBL
    {
        //public static bool EstacionaCarro(CarrosBO.Carro c)
        public static bool EstacionaCarro(CarrosBO.Carro c)
        {
            if(c == null) 
                return false;

            if (String.Compare(c.matricula, "00.00.00") == 0)
                return false;
            return CarroDB.Garagem.Estaciona(c);

        }
    }
}
