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
    public partial class Frmreportefactura : Form
    {
        public Frmreportefactura()
        {
            InitializeComponent();
        }

        private void Frmreportefactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.reportes.FACTURA);

            this.reportViewer1.RefreshReport();
        }
    }
}
