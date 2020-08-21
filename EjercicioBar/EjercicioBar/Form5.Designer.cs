namespace EjercicioBar
{
    partial class Form5
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblidVenta = new System.Windows.Forms.Label();
            this.IblEmpleadoVent = new System.Windows.Forms.Label();
            this.lblClienteVen = new System.Windows.Forms.Label();
            this.lblProdVen = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.cbEmpVen = new System.Windows.Forms.ComboBox();
            this.cbClienVen = new System.Windows.Forms.ComboBox();
            this.cbProdVen = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lvVenta = new System.Windows.Forms.ListView();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarVen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMesas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(319, 49);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(110, 32);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // lblidVenta
            // 
            this.lblidVenta.AutoSize = true;
            this.lblidVenta.Location = new System.Drawing.Point(50, 110);
            this.lblidVenta.Name = "lblidVenta";
            this.lblidVenta.Size = new System.Drawing.Size(81, 20);
            this.lblidVenta.TabIndex = 1;
            this.lblidVenta.Text = "ID Venta: ";
            // 
            // IblEmpleadoVent
            // 
            this.IblEmpleadoVent.AutoSize = true;
            this.IblEmpleadoVent.Location = new System.Drawing.Point(50, 193);
            this.IblEmpleadoVent.Name = "IblEmpleadoVent";
            this.IblEmpleadoVent.Size = new System.Drawing.Size(89, 20);
            this.IblEmpleadoVent.TabIndex = 2;
            this.IblEmpleadoVent.Text = "Empleado: ";
            // 
            // lblClienteVen
            // 
            this.lblClienteVen.AutoSize = true;
            this.lblClienteVen.Location = new System.Drawing.Point(50, 253);
            this.lblClienteVen.Name = "lblClienteVen";
            this.lblClienteVen.Size = new System.Drawing.Size(66, 20);
            this.lblClienteVen.TabIndex = 3;
            this.lblClienteVen.Text = "Cliente: ";
            // 
            // lblProdVen
            // 
            this.lblProdVen.AutoSize = true;
            this.lblProdVen.Location = new System.Drawing.Point(50, 309);
            this.lblProdVen.Name = "lblProdVen";
            this.lblProdVen.Size = new System.Drawing.Size(81, 20);
            this.lblProdVen.TabIndex = 4;
            this.lblProdVen.Text = "Producto: ";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(138, 110);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 26);
            this.txtIdVenta.TabIndex = 5;
            // 
            // cbEmpVen
            // 
            this.cbEmpVen.FormattingEnabled = true;
            this.cbEmpVen.Location = new System.Drawing.Point(145, 193);
            this.cbEmpVen.Name = "cbEmpVen";
            this.cbEmpVen.Size = new System.Drawing.Size(155, 28);
            this.cbEmpVen.TabIndex = 6;
            // 
            // cbClienVen
            // 
            this.cbClienVen.FormattingEnabled = true;
            this.cbClienVen.Location = new System.Drawing.Point(123, 253);
            this.cbClienVen.Name = "cbClienVen";
            this.cbClienVen.Size = new System.Drawing.Size(178, 28);
            this.cbClienVen.TabIndex = 7;
            // 
            // cbProdVen
            // 
            this.cbProdVen.FormattingEnabled = true;
            this.cbProdVen.Location = new System.Drawing.Point(138, 309);
            this.cbProdVen.Name = "cbProdVen";
            this.cbProdVen.Size = new System.Drawing.Size(237, 28);
            this.cbProdVen.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(285, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 43);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(165, 376);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(73, 20);
            this.lblCant.TabIndex = 11;
            this.lblCant.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(172, 408);
            this.txtCant.Multiline = true;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(61, 37);
            this.txtCant.TabIndex = 12;
            // 
            // lvVenta
            // 
            this.lvVenta.Location = new System.Drawing.Point(461, 121);
            this.lvVenta.Name = "lvVenta";
            this.lvVenta.Size = new System.Drawing.Size(324, 249);
            this.lvVenta.TabIndex = 13;
            this.lvVenta.UseCompatibleStateImageBehavior = false;
            this.lvVenta.View = System.Windows.Forms.View.List;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(435, 408);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(94, 37);
            this.btnTotal.TabIndex = 14;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(535, 408);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 39);
            this.txtTotal.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(617, 472);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 43);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarVen
            // 
            this.btnGuardarVen.Location = new System.Drawing.Point(675, 531);
            this.btnGuardarVen.Name = "btnGuardarVen";
            this.btnGuardarVen.Size = new System.Drawing.Size(137, 41);
            this.btnGuardarVen.TabIndex = 17;
            this.btnGuardarVen.Text = "Guardar Venta";
            this.btnGuardarVen.UseVisualStyleBackColor = true;
            this.btnGuardarVen.Click += new System.EventHandler(this.btnGuardarVen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mesa:";
            // 
            // cbMesas
            // 
            this.cbMesas.FormattingEnabled = true;
            this.cbMesas.Location = new System.Drawing.Point(113, 150);
            this.cbMesas.Name = "cbMesas";
            this.cbMesas.Size = new System.Drawing.Size(75, 28);
            this.cbMesas.TabIndex = 19;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 584);
            this.Controls.Add(this.cbMesas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarVen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lvVenta);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbProdVen);
            this.Controls.Add(this.cbClienVen);
            this.Controls.Add(this.cbEmpVen);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.lblProdVen);
            this.Controls.Add(this.lblClienteVen);
            this.Controls.Add(this.IblEmpleadoVent);
            this.Controls.Add(this.lblidVenta);
            this.Controls.Add(this.lblVentas);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblidVenta;
        private System.Windows.Forms.Label IblEmpleadoVent;
        private System.Windows.Forms.Label lblClienteVen;
        private System.Windows.Forms.Label lblProdVen;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.ComboBox cbEmpVen;
        private System.Windows.Forms.ComboBox cbClienVen;
        private System.Windows.Forms.ComboBox cbProdVen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.ListView lvVenta;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMesas;
    }
}