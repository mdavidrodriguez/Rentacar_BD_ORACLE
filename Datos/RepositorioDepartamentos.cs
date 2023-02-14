using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Datos
{
    public class RepositorioDepartamentos : Conexion, ICRUDDepartamentos<Departamentos>
    {
        public Departamentos BuscarDepartamento(string departamento)
        {
            throw new NotImplementedException();
        }

        public List<Departamentos> Todos(string dep)
        {
            throw new NotImplementedException();
        }
    }
}
