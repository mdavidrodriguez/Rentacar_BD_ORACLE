using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class Frm_ClientesReporte : Form
    {
        public Frm_ClientesReporte()
        {
            InitializeComponent();
        }

        private void Frm_ClientesReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.reportes.CLIENTES);

            this.reportViewer1.RefreshReport();
        }
    }
}
