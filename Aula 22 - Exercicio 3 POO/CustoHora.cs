using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Exercicio_3_POO
{
    class CustoHora
    {
        public DateTime DataAtributo { get; set; }
        public double ValorPorHoraAtributo { get; set; }
        public int HorasAtributo { get; set; }

        public CustoHora()
        { }

        public CustoHora(DateTime dataParametro, double valorPorHoraParametro, int horasParametro)
        {
            DataAtributo = dataParametro;
            ValorPorHoraAtributo = valorPorHoraParametro;
            HorasAtributo = horasParametro;
        }

        public Double ValorTotal()
        {
            return HorasAtributo * ValorPorHoraAtributo;
        }
    }
}
