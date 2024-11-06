using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_9___Lista_ficheiros_camadas
{
    public interface IColaborador
    {
        //Defina uma interface onde deverá especifcar os seguintes métodos:
        //QtdDeAnosDeColaboracao()
        //ValidarTamahoDoNif()

        int QtdAnos();

        bool ValidaTamanhoNIF(string nifParametro);
    }
}
