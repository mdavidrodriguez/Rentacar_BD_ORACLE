using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUDDepartamentos<Departamento>
    {
        Departamento BuscarDepartamento(string departamento);
        List<Departamento> Todos(string dep);

    }
}
