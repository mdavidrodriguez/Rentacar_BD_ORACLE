namespace Presentacion
{
    partial class FrmVehiculo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboxmarca = new System.Windows.Forms.ComboBox();
            this.numericmodelo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboxcolor = new System.Windows.Forms.ComboBox();
            this.comboxestado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.listavehiculos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labael = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericmodelo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 425);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Vehiculos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxmarca);
            this.groupBox2.Controls.Add(this.numericmodelo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboxcolor);
            this.groupBox2.Controls.Add(this.comboxestado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKilometraje);
            this.groupBox2.Controls.Add(this.listavehiculos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labael);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // comboxmarca
            // 
            this.comboxmarca.FormattingEnabled = true;
            this.comboxmarca.Location = new System.Drawing.Point(87, 64);
            this.comboxmarca.Name = "comboxmarca";
            this.comboxmarca.Size = new System.Drawing.Size(121, 21);
            this.comboxmarca.TabIndex = 18;
            // 
            // numericmodelo
            // 
            this.numericmodelo.Location = new System.Drawing.Point(283, 31);
            this.numericmodelo.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericmodelo.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericmodelo.Name = "numericmodelo";
            this.numericmodelo.Size = new System.Drawing.Size(120, 20);
            this.numericmodelo.TabIndex = 17;
            this.numericmodelo.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Color";
            // 
            // comboxcolor
            // 
            this.comboxcolor.FormattingEnabled = true;
            this.comboxcolor.Location = new System.Drawing.Point(282, 95);
            this.comboxcolor.Name = "comboxcolor";
            this.comboxcolor.Size = new System.Drawing.Size(121, 21);
            this.comboxcolor.TabIndex = 13;
            // 
            // comboxestado
            // 
            this.comboxestado.FormattingEnabled = true;
            this.comboxestado.Items.AddRange(new object[] {
            "DISPONIBLE",
            "OCUPADO"});
            this.comboxestado.Location = new System.Drawing.Point(284, 64);
            this.comboxestado.Name = "comboxestado";
            this.comboxestado.Size = new System.Drawing.Size(121, 21);
            this.comboxestado.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(87, 91);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(120, 20);
            this.txtKilometraje.TabIndex = 7;
            // 
            // listavehiculos
            // 
            this.listavehiculos.FormattingEnabled = true;
            this.listavehiculos.Location = new System.Drawing.Point(508, 6);
            this.listavehiculos.Name = "listavehiculos";
            this.listavehiculos.Size = new System.Drawing.Size(210, 121);
            this.listavehiculos.TabIndex = 6;
            this.listavehiculos.SelectedIndexChanged += new System.EventHandler(this.listavehiculos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Km Actual";
            // 
            // labael
            // 
            this.labael.AutoSize = true;
            this.labael.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labael.Location = new System.Drawing.Point(39, 62);
            this.labael.Name = "labael";
            this.labael.Size = new System.Drawing.Size(42, 13);
            this.labael.TabIndex = 2;
            this.labael.Text = "Marca";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(87, 31);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(120, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(26, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(39, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 35);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(381, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 35);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(495, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(609, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(267, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(153, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCondicion);
            this.tabPage2.Controls.Add(this.grillaVehiculos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(122, 6);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(110, 20);
            this.txtCondicion.TabIndex = 1;
            this.txtCondicion.TextChanged += new System.EventHandler(this.txtCondicion_TextChanged);
            // 
            // grillaVehiculos
            // 
            this.grillaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVehiculos.Location = new System.Drawing.Point(31, 31);
            this.grillaVehiculos.Name = "grillaVehiculos";
            this.grillaVehiculos.RowHeadersWidth = 62;
            this.grillaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaVehiculos.Size = new System.Drawing.Size(656, 271);
            this.grillaVehiculos.TabIndex = 0;
            this.grillaVehiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVehiculos_CellDoubleClick);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(807, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericmodelo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listavehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labael;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboxcolor;
        private System.Windows.Forms.ComboBox comboxestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericmodelo;
        private System.Windows.Forms.ComboBox comboxmarca;
    }
}