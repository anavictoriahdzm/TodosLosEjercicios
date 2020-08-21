namespace EjercicioBar
{
    partial class Form2
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
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblTipoProv = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.txtTelProv = new System.Windows.Forms.TextBox();
            this.txtProductoProv = new System.Windows.Forms.TextBox();
            this.txtRFCProv = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(421, 30);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(163, 29);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "Proveedores";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(72, 144);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(69, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(72, 192);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(79, 20);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefono: ";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(72, 236);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(77, 20);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // lblTipoProv
            // 
            this.lblTipoProv.AutoSize = true;
            this.lblTipoProv.Location = new System.Drawing.Point(72, 285);
            this.lblTipoProv.Name = "lblTipoProv";
            this.lblTipoProv.Size = new System.Drawing.Size(47, 20);
            this.lblTipoProv.TabIndex = 4;
            this.lblTipoProv.Text = "Tipo: ";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(72, 331);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(50, 20);
            this.lblRFC.TabIndex = 5;
            this.lblRFC.Text = "RFC: ";
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(147, 144);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(184, 26);
            this.txtNomProv.TabIndex = 6;
            // 
            // txtTelProv
            // 
            this.txtTelProv.Location = new System.Drawing.Point(157, 189);
            this.txtTelProv.Name = "txtTelProv";
            this.txtTelProv.Size = new System.Drawing.Size(174, 26);
            this.txtTelProv.TabIndex = 7;
            // 
            // txtProductoProv
            // 
            this.txtProductoProv.Location = new System.Drawing.Point(152, 233);
            this.txtProductoProv.Name = "txtProductoProv";
            this.txtProductoProv.Size = new System.Drawing.Size(178, 26);
            this.txtProductoProv.TabIndex = 8;
            // 
            // txtRFCProv
            // 
            this.txtRFCProv.Location = new System.Drawing.Point(127, 325);
            this.txtRFCProv.Name = "txtRFCProv";
            this.txtRFCProv.Size = new System.Drawing.Size(203, 26);
            this.txtRFCProv.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(244, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 36);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdProv
            // 
            this.lblIdProv.AutoSize = true;
            this.lblIdProv.Location = new System.Drawing.Point(72, 106);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(34, 20);
            this.lblIdProv.TabIndex = 12;
            this.lblIdProv.Text = "ID: ";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(147, 103);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(183, 26);
            this.txtIdProv.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(347, 385);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 36);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(291, 434);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 33);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbTipoProveedor
            // 
            this.cbTipoProveedor.FormattingEnabled = true;
            this.cbTipoProveedor.Location = new System.Drawing.Point(125, 282);
            this.cbTipoProveedor.Name = "cbTipoProveedor";
            this.cbTipoProveedor.Size = new System.Drawing.Size(182, 28);
            this.cbTipoProveedor.TabIndex = 16;
            // 
            // dgvProv
            // 
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Proveedor,
            this.NombreProv,
            this.TelProv,
            this.ProductoProv,
            this.TipoProv,
            this.RFCProv});
            this.dgvProv.Location = new System.Drawing.Point(402, 106);
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.RowTemplate.Height = 28;
            this.dgvProv.Size = new System.Drawing.Size(645, 229);
            this.dgvProv.TabIndex = 17;
            // 
            // Id_Proveedor
            // 
            this.Id_Proveedor.HeaderText = "Id Proveedor";
            this.Id_Proveedor.Name = "Id_Proveedor";
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "Nombre Proveedor";
            this.NombreProv.Name = "NombreProv";
            // 
            // TelProv
            // 
            this.TelProv.HeaderText = "Telefono";
            this.TelProv.Name = "TelProv";
            // 
            // ProductoProv
            // 
            this.ProductoProv.HeaderText = "Producto";
            this.ProductoProv.Name = "ProductoProv";
            // 
            // TipoProv
            // 
            this.TipoProv.HeaderText = "Tipo Proveedor";
            this.TipoProv.Name = "TipoProv";
            // 
            // RFCProv
            // 
            this.RFCProv.HeaderText = "RFC";
            this.RFCProv.Name = "RFCProv";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 479);
            this.Controls.Add(this.dgvProv);
            this.Controls.Add(this.cbTipoProveedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.lblIdProv);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRFCProv);
            this.Controls.Add(this.txtProductoProv);
            this.Controls.Add(this.txtTelProv);
            this.Controls.Add(this.txtNomProv);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblTipoProv);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblProveedores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTipoProv;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.TextBox txtTelProv;
        private System.Windows.Forms.TextBox txtProductoProv;
        private System.Windows.Forms.TextBox txtRFCProv;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbTipoProveedor;
        private System.Windows.Forms.DataGridView dgvProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCProv;
    }
}