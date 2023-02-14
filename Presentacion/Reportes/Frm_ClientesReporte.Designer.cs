namespace Presentacion.Reportes
{
    partial class Frm_ClientesReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new Presentacion.Reportes.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cLIENTESTableAdapter = new Presentacion.Reportes.ReportesTableAdapters.CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.reportes;
            // 
            // reportes
            // 
            this.reportes.DataSetName = "Reportes";
            this.reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Reporte_Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(932, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ClientesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ClientesReporte";
            this.Text = "Frm_ClientesReporte";
            this.Load += new System.EventHandler(this.Frm_ClientesReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes reportes;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private ReportesTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
    }
}