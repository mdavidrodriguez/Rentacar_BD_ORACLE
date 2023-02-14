namespace Presentacion
{
    partial class PaginaPrincipal
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
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.submenuOpciones = new System.Windows.Forms.Panel();
            this.btnconsultarfactura = new System.Windows.Forms.Button();
            this.btnalquiler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.panelimage = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneldow = new System.Windows.Forms.Panel();
            this.paneleshijos = new System.Windows.Forms.Panel();
            this.btnreportecliente = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnfactura = new System.Windows.Forms.Button();
            this.panel_lateral.SuspendLayout();
            this.submenuOpciones.SuspendLayout();
            this.panelimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.AutoScroll = true;
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel_lateral.Controls.Add(this.btnsalir);
            this.panel_lateral.Controls.Add(this.submenuOpciones);
            this.panel_lateral.Controls.Add(this.btnImagen);
            this.panel_lateral.Controls.Add(this.panelimage);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(210, 555);
            this.panel_lateral.TabIndex = 0;
            // 
            // submenuOpciones
            // 
            this.submenuOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.submenuOpciones.Controls.Add(this.btnfactura);
            this.submenuOpciones.Controls.Add(this.button2);
            this.submenuOpciones.Controls.Add(this.btnreportecliente);
            this.submenuOpciones.Controls.Add(this.btnconsultarfactura);
            this.submenuOpciones.Controls.Add(this.btnalquiler);
            this.submenuOpciones.Controls.Add(this.button3);
            this.submenuOpciones.Controls.Add(this.btnClientes);
            this.submenuOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuOpciones.Location = new System.Drawing.Point(0, 145);
            this.submenuOpciones.Name = "submenuOpciones";
            this.submenuOpciones.Size = new System.Drawing.Size(210, 282);
            this.submenuOpciones.TabIndex = 2;
            // 
            // btnconsultarfactura
            // 
            this.btnconsultarfactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsultarfactura.FlatAppearance.BorderSize = 0;
            this.btnconsultarfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultarfactura.ForeColor = System.Drawing.Color.DarkGray;
            this.btnconsultarfactura.Location = new System.Drawing.Point(0, 120);
            this.btnconsultarfactura.Name = "btnconsultarfactura";
            this.btnconsultarfactura.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnconsultarfactura.Size = new System.Drawing.Size(210, 40);
            this.btnconsultarfactura.TabIndex = 3;
            this.btnconsultarfactura.Text = "CONSULTAR FACTURA";
            this.btnconsultarfactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultarfactura.UseVisualStyleBackColor = true;
            this.btnconsultarfactura.Click += new System.EventHandler(this.btnconsultarfactura_Click);
            // 
            // btnalquiler
            // 
            this.btnalquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnalquiler.FlatAppearance.BorderSize = 0;
            this.btnalquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalquiler.ForeColor = System.Drawing.Color.DarkGray;
            this.btnalquiler.Location = new System.Drawing.Point(0, 80);
            this.btnalquiler.Name = "btnalquiler";
            this.btnalquiler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnalquiler.Size = new System.Drawing.Size(210, 40);
            this.btnalquiler.TabIndex = 2;
            this.btnalquiler.Text = "ALQUILAR VEHICULO";
            this.btnalquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalquiler.UseVisualStyleBackColor = true;
            this.btnalquiler.Click += new System.EventHandler(this.btnalquiler_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "VEHICULOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(210, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImagen.Location = new System.Drawing.Point(0, 100);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImagen.Size = new System.Drawing.Size(210, 45);
            this.btnImagen.TabIndex = 1;
            this.btnImagen.Text = "OPCIONES";
            this.btnImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // panelimage
            // 
            this.panelimage.Controls.Add(this.pictureBox2);
            this.panelimage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelimage.Location = new System.Drawing.Point(0, 0);
            this.panelimage.Name = "panelimage";
            this.panelimage.Size = new System.Drawing.Size(210, 100);
            this.panelimage.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.rentacarhello_scaled;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // paneldow
            // 
            this.paneldow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.paneldow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldow.Location = new System.Drawing.Point(210, 455);
            this.paneldow.Name = "paneldow";
            this.paneldow.Size = new System.Drawing.Size(567, 100);
            this.paneldow.TabIndex = 1;
            // 
            // paneleshijos
            // 
            this.paneleshijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.paneleshijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneleshijos.Location = new System.Drawing.Point(210, 0);
            this.paneleshijos.Name = "paneleshijos";
            this.paneleshijos.Size = new System.Drawing.Size(567, 455);
            this.paneleshijos.TabIndex = 2;
            // 
            // btnreportecliente
            // 
            this.btnreportecliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreportecliente.FlatAppearance.BorderSize = 0;
            this.btnreportecliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportecliente.ForeColor = System.Drawing.Color.DarkGray;
            this.btnreportecliente.Location = new System.Drawing.Point(0, 160);
            this.btnreportecliente.Name = "btnreportecliente";
            this.btnreportecliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnreportecliente.Size = new System.Drawing.Size(210, 40);
            this.btnreportecliente.TabIndex = 6;
            this.btnreportecliente.Text = "REPORTE CLIENTE";
            this.btnreportecliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportecliente.UseVisualStyleBackColor = true;
            this.btnreportecliente.Click += new System.EventHandler(this.btnreportecliente_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.DarkGray;
            this.btnsalir.Location = new System.Drawing.Point(0, 427);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(210, 40);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(210, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "REPORTE VEHICULO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnfactura
            // 
            this.btnfactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfactura.FlatAppearance.BorderSize = 0;
            this.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfactura.ForeColor = System.Drawing.Color.DarkGray;
            this.btnfactura.Location = new System.Drawing.Point(0, 240);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnfactura.Size = new System.Drawing.Size(210, 40);
            this.btnfactura.TabIndex = 9;
            this.btnfactura.Text = "REPORTE FACTURA";
            this.btnfactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfactura.UseVisualStyleBackColor = true;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 555);
            this.Controls.Add(this.paneleshijos);
            this.Controls.Add(this.paneldow);
            this.Controls.Add(this.panel_lateral);
            this.MinimumSize = new System.Drawing.Size(793, 548);
            this.Name = "PaginaPrincipal";
            this.Text = "Renta Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_lateral.ResumeLayout(false);
            this.submenuOpciones.ResumeLayout(false);
            this.panelimage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel submenuOpciones;
        private System.Windows.Forms.Button btnconsultarfactura;
        private System.Windows.Forms.Button btnalquiler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Panel panelimage;
        private System.Windows.Forms.Panel paneldow;
        private System.Windows.Forms.Panel paneleshijos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnreportecliente;
        private System.Windows.Forms.Button btnfactura;
    }
}