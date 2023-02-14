using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using OracleCommand = Oracle.ManagedDataAccess.Client.OracleCommand;
using OracleDataAdapter = Oracle.ManagedDataAccess.Client.OracleDataAdapter;

namespace Datos.BDatosOracle
{
    public class RepositorioVehiculos : Conexion, Datos.BDatosOracle.ICRUDVEHICULO<Vehiculo>
    {
        Conexion cn = new Conexion();
        public string Actualizar(Vehiculo objs)
        {
            try
            {
                using (var Comando = conexiones.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_VEHICULOS.sp_modificar_vehiculo";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.Parameters.Add("@mar", OracleDbType.Varchar2).Value = objs.Marca;
                    Comando.Parameters.Add("@kilom", OracleDbType.Int32).Value = objs.KilometrajeActual;
                    Comando.Parameters.Add("@modelos", OracleDbType.Varchar2).Value = objs.modelo;
                    Comando.Parameters.Add("@estad", OracleDbType.Varchar2).Value = objs.color;
                    Comando.Parameters.Add("@colores", OracleDbType.Varchar2).Value = objs.estado;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "se actualizo el vehiculo con placa: " + objs.PlacaVehiculo;
                    CerrarConnexion();
                }

            }
            catch (Exception e)
            {

                return e.Message;
            }


        }

        public Vehiculo BuscarPlaca(string placa)
        {
            try
            {
                string _sql = string.Format("select * from Vehiculos where Placa='{0}'", placa);
                var cmd = new OracleCommand(_sql, conexiones);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Vehiculo(reader.GetString(0), reader.GetString(1), reader.GetInt32(2),reader.GetInt32(3),reader.GetString(4),reader.GetString(5));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public string Eliminar(Vehiculo objs)
        {
            try
            {
                AbrirConnexion();
                using (var Comando = conexiones.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_VEHICULOS.sp_eliminar_vehiculo";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "cliente con id = " + objs.PlacaVehiculo + " eliminado correctamente";
                    AbrirConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Insertar(Vehiculo objs)
        {
            try
            {
                using (var Comando = conexiones.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_VEHICULOS.sp_guardar_vehiculo";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.Parameters.Add("@mar", OracleDbType.Varchar2).Value = objs.Marca;
                    Comando.Parameters.Add("@kilom", OracleDbType.Int32).Value = objs.KilometrajeActual;
                    Comando.Parameters.Add("@modelos", OracleDbType.Varchar2).Value = objs.modelo;
                    Comando.Parameters.Add("@estad", OracleDbType.Varchar2).Value = objs.estado;
                    Comando.Parameters.Add("@colores", OracleDbType.Varchar2).Value = objs.color;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }


        public List<Vehiculo> Todos2(string condicion)
        {
            OracleCommand comando = new OracleCommand("sp_listar_vehiculos", conexiones);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConnexion();

            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }






        public List<Vehiculo> Todos(string condicion)
        {
            OracleCommand comando = new OracleCommand("MANTENIMIENTO_VEHICULOS.sp_consultar_vehiculos", conexiones);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConnexion();

            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
       
        }
        Vehiculo map(DataRow fila)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.PlacaVehiculo = (string)fila[0];
            vehiculo.Marca = (string)fila[1];
            vehiculo.KilometrajeActual = Convert.ToInt32(fila[2]);
            vehiculo.modelo = (int)(decimal) fila[3];
            vehiculo.estado = (string) fila[4];
            vehiculo.color = (string)fila[5];
            return vehiculo;
        }
        public DataTable cargarmarca()
        {
            OracleCommand dt = new OracleCommand("sp_cargar_marca", conexiones);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("marcas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public DataTable cargarcolor()
        {
            OracleCommand dt = new OracleCommand("sp_cargar_color", conexiones);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("colores", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

       


    }
}
