using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___Revisoes
{
    public interface IPessoa
    {
        // Um metodo que recebe uma lista de
        // medias de percurso escolar
        // e devolve caso sendo maior que 14
        // positivo ou negativo em caso contrario

        bool AceitacaoPercursoEscolar(List<int> listaPercursoEscolar);
    }
}
