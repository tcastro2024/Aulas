using GereCarrosNTier.CarroBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCarrosNTier.CarroDB
{
    class Garagem
    {
        static List<CarrosBO.Carro> garag;

        static Garagem()
        {
            garag = new List<CarrosBO.Carro>();
        }

        public static bool Estaciona(CarrosBO.Carro c)
        {
            if (!garag.Contains(c))
            {
                garag.Add(c); 
                return true;
            }

            return false;
        }
    }
}
