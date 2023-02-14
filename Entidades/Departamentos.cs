using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamentos
    {
        public Departamentos(int codigoDepartamento, string nombreDepartamento)
        {
            this.codigoDepartamento = codigoDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }
        public Departamentos()
        {

        }

        public int codigoDepartamento { get; set; }
        public string nombreDepartamento { get; set; }

    }
}
