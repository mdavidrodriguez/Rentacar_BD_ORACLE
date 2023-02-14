using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class Conexion
    {
        private static Conexion Con = null;
        protected OracleConnection conexiones;
        protected string cadenaConexion;
       //public  OracleConnection conectar = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=RentaVehiculos;Password=renta;");
        public Conexion()
        {
            string cadenaConexion = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=RentaVehiculos;Password=renta;");


            conexiones = new OracleConnection(cadenaConexion);

        }

        public string AbrirConnexion()
        {
            if (conexiones.State == System.Data.ConnectionState.Open)
            {
                CerrarConnexion();
            }
            conexiones.Open();
            return conexiones.State.ToString();
        }
        public void CerrarConnexion()
        {
            conexiones.Close();
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }




    }
}
