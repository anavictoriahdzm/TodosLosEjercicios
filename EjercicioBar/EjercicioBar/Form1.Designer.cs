namespace EjercicioBar
{
    partial class Form1
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipoEmpl = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTipoEmpl = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDescPuesto = new System.Windows.Forms.Label();
            this.txtDescPuesto = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblIdEmpl = new System.Windows.Forms.Label();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.idEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(156, 30);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(169, 37);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(55, 156);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(73, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(55, 210);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(163, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(55, 258);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(71, 20);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero: ";
            // 
            // lblTipoEmpl
            // 
            this.lblTipoEmpl.AutoSize = true;
            this.lblTipoEmpl.Location = new System.Drawing.Point(55, 307);
            this.lblTipoEmpl.Name = "lblTipoEmpl";
            this.lblTipoEmpl.Size = new System.Drawing.Size(145, 20);
            this.lblTipoEmpl.TabIndex = 4;
            this.lblTipoEmpl.Text = "Tipo de Empleado: ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 153);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(267, 26);
            this.txtNom.TabIndex = 5;
            // 
            // txtTipoEmpl
            // 
            this.txtTipoEmpl.Location = new System.Drawing.Point(207, 301);
            this.txtTipoEmpl.Name = "txtTipoEmpl";
            this.txtTipoEmpl.Size = new System.Drawing.Size(299, 26);
            this.txtTipoEmpl.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(478, 418);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 37);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblDescPuesto
            // 
            this.lblDescPuesto.AutoSize = true;
            this.lblDescPuesto.Location = new System.Drawing.Point(55, 354);
            this.lblDescPuesto.Name = "lblDescPuesto";
            this.lblDescPuesto.Size = new System.Drawing.Size(178, 20);
            this.lblDescPuesto.TabIndex = 11;
            this.lblDescPuesto.Text = "Descripcion del puesto: ";
            // 
            // txtDescPuesto
            // 
            this.txtDescPuesto.Location = new System.Drawing.Point(244, 351);
            this.txtDescPuesto.Name = "txtDescPuesto";
            this.txtDescPuesto.Size = new System.Drawing.Size(262, 26);
            this.txtDescPuesto.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(362, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 37);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Seleccionar",
            "Femenino",
            "Masculino"});
            this.cbGenero.Location = new System.Drawing.Point(132, 252);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(181, 28);
            this.cbGenero.TabIndex = 14;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleados,
            this.nomEmpleado,
            this.fechaEmp,
            this.GeneroEmp,
            this.TipoEmp,
            this.DecEmp});
            this.dgvEmpleados.Location = new System.Drawing.Point(586, 77);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 28;
            this.dgvEmpleados.Size = new System.Drawing.Size(530, 238);
            this.dgvEmpleados.TabIndex = 15;
            // 
            // lblIdEmpl
            // 
            this.lblIdEmpl.AutoSize = true;
            this.lblIdEmpl.Location = new System.Drawing.Point(55, 106);
            this.lblIdEmpl.Name = "lblIdEmpl";
            this.lblIdEmpl.Size = new System.Drawing.Size(108, 20);
            this.lblIdEmpl.TabIndex = 16;
            this.lblIdEmpl.Text = "ID empleado: ";
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(163, 106);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(117, 26);
            this.txtIdEmp.TabIndex = 17;
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Location = new System.Drawing.Point(594, 417);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(91, 38);
            this.btnBuscarEmp.TabIndex = 18;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // idEmpleados
            // 
            this.idEmpleados.HeaderText = "ID Empleado";
            this.idEmpleados.Name = "idEmpleados";
            // 
            // nomEmpleado
            // 
            this.nomEmpleado.HeaderText = "Nombre";
            this.nomEmpleado.Name = "nomEmpleado";
            // 
            // fechaEmp
            // 
            this.fechaEmp.HeaderText = "Fecha de Nacimiento";
            this.fechaEmp.Name = "fechaEmp";
            // 
            // GeneroEmp
            // 
            this.GeneroEmp.HeaderText = "Genero";
            this.GeneroEmp.Name = "GeneroEmp";
            // 
            // TipoEmp
            // 
            this.TipoEmp.HeaderText = "Tipo de Empleado";
            this.TipoEmp.Name = "TipoEmp";
            // 
            // DecEmp
            // 
            this.DecEmp.HeaderText = "Descripcion del puesto";
            this.DecEmp.Name = "DecEmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 525);
            this.Controls.Add(this.btnBuscarEmp);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.lblIdEmpl);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDescPuesto);
            this.Controls.Add(this.lblDescPuesto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTipoEmpl);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTipoEmpl);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipoEmpl;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTipoEmpl;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDescPuesto;
        private System.Windows.Forms.TextBox txtDescPuesto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblIdEmpl;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecEmp;
    }
}

