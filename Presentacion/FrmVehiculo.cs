using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;
using Entidades;
using Datos.BDatosOracle;
using RepositorioVehiculos = Datos.BDatosOracle.RepositorioVehiculos;

namespace Presentacion
{
    public partial class FrmVehiculo : Form
    {
        private static FrmVehiculo instacias = null;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        public static FrmVehiculo GetInstancias()
        {
            if (instacias == null || instacias.IsDisposed)
            {
                instacias = new FrmVehiculo();
            }
            return instacias;
        }
        private void Listado_vehiculos(string cTexto)
        {
            listavehiculos.DataSource = servicioVehiculo.Listar_vehiculos(cTexto);
            this.CargarLista(cTexto);
        }

        public void cargarmarcas()
        {
            comboxmarca.DataSource = rv.cargarmarca();
            comboxmarca.DisplayMember = "nombremarca";
            comboxmarca.ValueMember = "idmarca";
        }
        public void cargarcolor()
        {
            comboxcolor.DataSource = rv.cargarcolor();
            comboxcolor.DisplayMember = "nombre_color";
            comboxcolor.ValueMember = "idcolor";
        }



        RepositorioVehiculos rv = new RepositorioVehiculos();
        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            
            CargarGrillaVehiculos("");
            CargarLista("");
            this.Listado_vehiculos("%");
            cargarcolor();
            cargarmarcas();


        }

        void CargarLista(string condicion)
        {
            listavehiculos.DataSource = new RepositorioVehiculos().Todos(condicion);
            listavehiculos.DisplayMember = "marca";
            listavehiculos.ValueMember = "placaVehiculo";
            if (listavehiculos.Items.Count > 0)
            {
                listavehiculos.SelectedIndex = 0;
                listavehiculos.Select();
            }
            
        }
        void CargarGrillaVehiculos(string condicion)
        {
            grillaVehiculos.DataSource = new RepositorioVehiculos().Todos2(condicion);
           


        }

        private void listavehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placa = listavehiculos.SelectedValue.ToString();
            Buscar(placa);
        }
        void Buscar(string placa)
        {
            try
            {
                var vehiculo = new RepositorioVehiculos().BuscarPlaca(placa);
                ver(vehiculo);
            }
            catch (Exception)
            {


            }
        }

        void ver(Entidades.Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                return;
            }
            txtPlaca.Text = vehiculo.PlacaVehiculo;
            comboxmarca.Text =vehiculo.Marca;
            txtKilometraje.Text =Convert.ToString( vehiculo.KilometrajeActual);
            numericmodelo.Text = Convert.ToString( vehiculo.modelo);
            comboxestado.Text = vehiculo.estado;
            comboxcolor.Text =vehiculo.color;

            
        }

        private void grillaVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string placa = grillaVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(placa);
            listavehiculos.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
           
        }

        private void txtCondicion_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtCondicion.Text.Trim();
            CargarGrillaVehiculos(condicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Esta seguro de eliminar el vehiculo?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion == DialogResult.Yes)
            {
                if (txtPlaca.Text.Length == 0)
                {
                    return;
                }
                Eliminar(new RepositorioVehiculos().BuscarPlaca(txtPlaca.Text));
                this.Listado_vehiculos("%");
            }



            
        }
        void Eliminar(Vehiculo vehiculo)
        {

            MessageBox.Show(new RepositorioVehiculos().Eliminar(vehiculo));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtPlaca.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo(txtPlaca.Text,Convert.ToString( comboxmarca.SelectedValue) ,int.Parse(txtKilometraje.Text),Convert.ToInt32(numericmodelo.Value),comboxestado.Text,Convert.ToString( comboxcolor.SelectedValue));
            Actualizar(vehiculo);
            this.Listado_vehiculos("%");

        }
        void Actualizar(Vehiculo vehiculo)
        {
            MessageBox.Show(new servicioVehiculo().Actualizar(vehiculo));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo(false);
            txtPlaca.Enabled = true;
            txtPlaca.Focus();
        }
        void Nuevo(bool soloLectura)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    ((TextBox)item).ReadOnly = soloLectura;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vh = new Vehiculo();
            vh.PlacaVehiculo = txtPlaca.Text;
            vh.Marca =Convert.ToString( comboxmarca.SelectedValue);
            vh.KilometrajeActual =int.Parse( txtKilometraje.Text);
            vh.modelo =Convert.ToInt32( numericmodelo.Value);
            vh.estado =comboxestado.Text;
            vh.color =Convert.ToString( comboxcolor.SelectedValue);
            Insertar(vh);
            this.Listado_vehiculos("%");

            //var vehiculo = new Vehiculo(txtPlaca.Text,comboxmarca.ValueMember, int.Parse(txtKilometraje.Text), Convert.ToInt32(numericmodelo.Value), comboxestado.Text,comboxcolor.ValueMember);
            //Insertar(vehiculo);

        }
        void Insertar(Vehiculo vehiculo)
        {
            MessageBox.Show(new servicioVehiculo().Guardar(vehiculo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form mv = new Form();
            this.Close();
        }

        #region
        //  Metodos para usar el evento keypress
        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese Caracteres", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

       
      
    }
}
