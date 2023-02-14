using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        
        public Cliente()
        {

        }

        public Cliente(string iDC, string nombre, string apellido, string fechaNacimiento, string genero, string tipoCliente, int telefono, string direcccion)
        {
            IDC = iDC;
            Nombre = nombre;
            Apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            Genero = genero;
            TipoCliente = tipoCliente;
            Telefono = telefono;
            this.direcccion = direcccion;
        }

        public string IDC { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string TipoCliente { get; set; }
        public int Telefono { get; set; }
        public string direcccion { get; set; }
    }
}
