namespace EjercicioBar
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbGeneroCliente = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(76, 122);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(30, 20);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "ID:";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(74, 173);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(73, 20);
            this.lblNomCliente.TabIndex = 2;
            this.lblNomCliente.Text = "Nombre: ";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(76, 225);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(165, 20);
            this.lblFechaNaci.TabIndex = 3;
            this.lblFechaNaci.Text = "Fecha de nacimiento: ";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(76, 269);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(71, 20);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero: ";
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.AutoSize = true;
            this.lblTelCliente.Location = new System.Drawing.Point(76, 313);
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(79, 20);
            this.lblTelCliente.TabIndex = 5;
            this.lblTelCliente.Text = "Telefono: ";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(113, 122);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(112, 26);
            this.txtIdCliente.TabIndex = 6;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(143, 173);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(277, 26);
            this.txtNomCliente.TabIndex = 7;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(162, 313);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(172, 26);
            this.txtTelCliente.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // cbGeneroCliente
            // 
            this.cbGeneroCliente.FormattingEnabled = true;
            this.cbGeneroCliente.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbGeneroCliente.Location = new System.Drawing.Point(143, 269);
            this.cbGeneroCliente.Name = "cbGeneroCliente";
            this.cbGeneroCliente.Size = new System.Drawing.Size(169, 28);
            this.cbGeneroCliente.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(258, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 37);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(383, 370);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 37);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.NomCliente,
            this.fechaCliente,
            this.GeneroCliente,
            this.TelCliente});
            this.dgvClientes.Location = new System.Drawing.Point(590, 122);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(623, 195);
            this.dgvClientes.TabIndex = 13;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id Cliente";
            this.idCliente.Name = "idCliente";
            // 
            // NomCliente
            // 
            this.NomCliente.HeaderText = "Nombre";
            this.NomCliente.Name = "NomCliente";
            // 
            // fechaCliente
            // 
            this.fechaCliente.HeaderText = "Fecha de Nacimiento";
            this.fechaCliente.Name = "fechaCliente";
            // 
            // GeneroCliente
            // 
            this.GeneroCliente.HeaderText = "Genero";
            this.GeneroCliente.Name = "GeneroCliente";
            // 
            // TelCliente
            // 
            this.TelCliente.HeaderText = "Telefono";
            this.TelCliente.Name = "TelCliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(324, 417);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 42);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 471);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbGeneroCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblTelCliente);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFechaNaci);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "{";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTelCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbGeneroCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCliente;
        private System.Windows.Forms.Button btnBuscar;
    }
}