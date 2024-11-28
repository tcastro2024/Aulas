using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Expressoes_Lambda_e_LINQ
{
    /// <summary>
    /// Compara students
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IEqualityComparer&lt;Aula_15___Expressoes_Lambda_e_LINQ.Student&gt;" />
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.Id == y.Id &&
                        x.Name.ToLower() == y.Name.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
