using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;


namespace Datos
{
    public class AlquilerRepository : Conexion, ICrudAlquiler<Alquiler>
    {
        public Alquiler BuscarFactura(int id)
        {
            throw new NotImplementedException();
        }


        public DataTable cargar_cliente()
        {
            OracleCommand dt = new OracleCommand("sp_cargar_cliente", conexiones);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("clientes", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }



        public List<Alquiler> ConsultarTodasFacturas(string condicion)
        {
            string _sql = string.Format("select * from factura where IdAlquiler like '{0}%' or idcliente like '{1}%'", condicion,condicion);
            System.Data.DataTable tabla = new DataTable("factura");
            OracleDataAdapter adapter = new OracleDataAdapter(_sql, conexiones);

            adapter.Fill(tabla);

            List<Alquiler> lista = new List<Alquiler>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }
        Alquiler map(DataRow fila)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.IdAlquiler = (int)(decimal)fila[0];
            alquiler.IdCliente = (string)fila[1];
            alquiler.Placa = (string)fila[2];
            alquiler.FechaEntrega  = (DateTime)fila[3];
            alquiler.FechaRecepcion = (DateTime)fila[4];
            alquiler.KmEntrega = (int)(decimal)fila[5];
            alquiler.KmRecepcion = (int)(decimal)fila[6];
            alquiler.KmRecorridos = (int)(decimal)fila[7];
            alquiler.ValorKm =(int)(decimal)fila[8];
            alquiler.Descuento = (int)(decimal)fila[9];
            alquiler.Total = (int)(decimal)fila[10];
            return alquiler;
        }

        public string Insertar(Alquiler alquileres)
        {
            try
            {
                using (var Comando = conexiones.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_FACTURA.sp_guardar_factura";
                    Comando.Parameters.Add("@plac", OracleDbType.Int32).Value = alquileres.IdAlquiler;
                    Comando.Parameters.Add("@mar", OracleDbType.Varchar2).Value = alquileres.IdCliente;
                    Comando.Parameters.Add("@kilom", OracleDbType.Varchar2).Value = alquileres.Placa;
                    Comando.Parameters.Add("@modelos", OracleDbType.Date).Value = alquileres.FechaEntrega;
                    Comando.Parameters.Add("@estad", OracleDbType.Date).Value = alquileres.FechaRecepcion;
                    Comando.Parameters.Add("@colores", OracleDbType.Int32).Value = alquileres.KmEntrega;
                    Comando.Parameters.Add("@colores", OracleDbType.Int32).Value = alquileres.KmRecepcion;
                    Comando.Parameters.Add("@colores", OracleDbType.Int32).Value = alquileres.KmRecorridos;
                    Comando.Parameters.Add("@colores", OracleDbType.Int32).Value = alquileres.ValorKm;
                    Comando.Parameters.Add("@colores", OracleDbType.Double).Value = alquileres.Descuento;
                    Comando.Parameters.Add("@colores", OracleDbType.Double).Value = alquileres.Total;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                    CerrarConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }








            //try
            //{
            //    string _sql = string.Format("INSERT INTO[dbo].[Alquileres] VALUES('" + alquileres.IdCliente + "','" + alquileres.Placa + "','" + alquileres.FechaEntrega + "','" + alquileres.FechaRecepcion + "','" + alquileres.KmEntrega + "','" + alquileres.KmRecepcion + "','" +
            //        alquileres.KmRecorridos + "','" + alquileres.ValorKm + "','" + alquileres.Descuento + "','" + alquileres.Total + "')"); ;
            //    var cmd = new OracleCommand(_sql, conexion);
            //    AbrirConnexion();
            //    int filas = cmd.ExecuteNonQuery();
            //    CerrarConnexion();
            //    if (filas > 0)
            //    {
            //        return "Datos guardados satisfactoriamente";
            //    }
            //    return "No se pudo guardar los datos";

            //}
            //catch (Exception e)
            //{

            //    return e.Message;
            //}
        }

        public DataTable cargarcliente()
        {
            OracleCommand dt = new OracleCommand("sp_idcliente_cargar", conexiones);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        public DataTable cargarplaca()
        {
            OracleCommand dt = new OracleCommand("sp_placa_cargar", conexiones);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }


    }
}
