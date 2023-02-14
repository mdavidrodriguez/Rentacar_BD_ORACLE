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
    public partial class Frmreportevehiculos : Form
    {
        public Frmreportevehiculos()
        {
            InitializeComponent();
        }

        private void Frmreportevehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes.VEHICULOS' Puede moverla o quitarla según sea necesario.
            this.vEHICULOSTableAdapter.Fill(this.reportes.VEHICULOS);

            this.reportViewer2.RefreshReport();
        }
    }
}
