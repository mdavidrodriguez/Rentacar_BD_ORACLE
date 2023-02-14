using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
#region
using System.Reflection;
using Oracle.ManagedDataAccess.Client;
using OracleTransaction = Oracle.ManagedDataAccess.Client.OracleTransaction;
#endregion;


namespace Datos.BDatosOracle
{
    public class RepositorioClientes : Conexion, Datos.BDatosOracle.ICRUDCLIENTE<Cliente>
    {
        public string Actualizar(Cliente obj)
        {

            try
            {
                using (var Comando = conexiones.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_CLIENTE.sp_modificar_cliente";
                    Comando.Parameters.Add("@idc", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.Parameters.Add("@nomb", OracleDbType.Varchar2).Value = obj.Nombre;
                    Comando.Parameters.Add("@apelli", OracleDbType.Varchar2).Value = obj.Apellido;
                    Comando.Parameters.Add("@fechaN", OracleDbType.Varchar2).Value = obj.fechaNacimiento;
                    Comando.Parameters.Add("@gen", OracleDbType.Varchar2).Value = obj.Genero;
                    Comando.Parameters.Add("@tipoc", OracleDbType.Varchar2).Value = obj.TipoCliente;
                    Comando.Parameters.Add("@tele", OracleDbType.Varchar2).Value = obj.Telefono;
                    Comando.Parameters.Add("@direc", OracleDbType.Varchar2).Value = obj.direcccion;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "se actualizo el registro con id: " + obj.IDC;
                    CerrarConnexion();
                }

            }
            catch (Exception e)
            {

                return e.Message;
            }


            //    try
            //    {
            //        string _sql = string.Format("UPDATE Clientes SET Nombre = '{0}', Apellido = '{1}',  fechanacimiento = '{2}', genero = '{3}',  tipocliente = '{4}', telefono = '{5}',  direccion = '{6}'  WHERE IdCliente = '{7}'", obj.Nombre, obj.Apellido,obj.fechaNacimiento,obj.Genero, obj.TipoCliente,obj.Telefono,obj.direcccion, obj.IDC);

            //        var cmd = new OracleCommand(_sql, conexiones);
            //        AbrirConnexion();
            //        int filas = cmd.ExecuteNonQuery();
            //        CerrarConnexion();
            //        if (filas == 1)
            //        {
            //            return "se Actualizo el registro del cliente cuyo id = :" + obj.IDC;
            //        }
            //        return "Imposible actualizar el registro del cliente cuyo id = :" + obj.IDC;
            //    }
            //    catch (Exception ex)
            //    {

            //        return ex.Message;
            //    }
        }




        public Cliente BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from clientes where IdCliente='{0}'", id);
                var cmd = new OracleCommand(_sql, conexiones);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                CerrarConnexion();
                return cliente;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public string Eliminar(Cliente obj)
        {
            try
            {
                AbrirConnexion();
                using (var Comando = conexiones.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_CLIENTE.sp_eliminar_cliente";
                    Comando.Parameters.Add("@ced", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "cliente con id = " + obj.IDC + " eliminado correctamente";
                    AbrirConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }


            //try
            //{
            //    string _sql = string.Format("DELETE FROM Clientes WHERE IdCliente='{0}'", obj.IDC);

            //    var cmd = new OracleCommand(_sql, conexiones);
            //    AbrirConnexion();
            //    int filas = cmd.ExecuteNonQuery();
            //    CerrarConnexion();
            //    if (filas == 1)
            //    {
            //        return "se elimino el registro del cliente cuyo id = :" + obj.IDC;
            //    }
            //    return "Imposible se eliminar el registro del cliente cuyo id = :" + obj.IDC;
            //}
            //catch (Exception ex)
            //{

            //    return ex.Message;
            //}
        }

        public string Insertar(Cliente obj)
        {
            try
            {
                using (var Comando = conexiones.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "MANTENIMIENTO_CLIENTE.sp_guardar_cliente";
                    Comando.Parameters.Add("@idc", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.Parameters.Add("@nomb", OracleDbType.Varchar2).Value = obj.Nombre;
                    Comando.Parameters.Add("@apelli", OracleDbType.Varchar2).Value = obj.Apellido;
                    Comando.Parameters.Add("@fechaN", OracleDbType.Date).Value = obj.fechaNacimiento;
                    Comando.Parameters.Add("@gen", OracleDbType.Varchar2).Value = obj.Genero;
                    Comando.Parameters.Add("@tipoc", OracleDbType.Varchar2).Value = obj.TipoCliente;
                    Comando.Parameters.Add("@tele", OracleDbType.Int32).Value = obj.Telefono;
                    Comando.Parameters.Add("@direc", OracleDbType.Varchar2).Value = obj.direcccion;
                    OracleTransaction tx = conexiones.BeginTransaction();
                    Comando.ExecuteNonQuery();
                    tx.Commit();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public List<Cliente> BuscarPorId(string condicion)
        {

            string sql = string.Format("select * from clientes where IdCliente like '{0}%' or Nombre like '%{1}%' or Apellido like '%{2}%'", condicion, condicion, condicion);
            System.Data.DataTable tabla = new DataTable("Clientes");

            OracleDataAdapter command = new OracleDataAdapter(sql, conexiones);
            command.Fill(tabla);
            List<Cliente> lista = new List<Cliente>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }

      



        public List<Cliente> Todos(string condicion)
        {
         


            //Procedimiento almacenado

            OracleCommand comando = new OracleCommand("listarpersonas", conexiones);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConnexion();

            List<Cliente> lista = new List<Cliente>();
            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }

            return lista;

        }

        Cliente map(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.IDC = (string)fila[0];
            cliente.Nombre = (string)fila[1];
            cliente.Apellido = (string)fila[2];
            cliente.fechaNacimiento =Convert.ToString( (DateTime)fila[3]);
            cliente.Genero = (string)fila[4];
            cliente.TipoCliente = (string)fila[5];
            cliente.Telefono = Convert.ToInt32( (decimal)fila[6]);
            cliente.direcccion = (string)fila[7];

            return cliente;
        }
    }
}



