namespace EjercicioBar
{
    partial class Form4
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblNomProd = new System.Windows.Forms.Label();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.lblProveedorProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.cbTipoProd = new System.Windows.Forms.ComboBox();
            this.cbProveedorProd = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(303, 50);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(137, 32);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(61, 118);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(99, 20);
            this.lblIdProd.TabIndex = 1;
            this.lblIdProd.Text = "Id Producto: ";
            // 
            // lblNomProd
            // 
            this.lblNomProd.AutoSize = true;
            this.lblNomProd.Location = new System.Drawing.Point(61, 173);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(73, 20);
            this.lblNomProd.TabIndex = 2;
            this.lblNomProd.Text = "Nombre: ";
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(61, 224);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(115, 20);
            this.lblTipoProd.TabIndex = 3;
            this.lblTipoProd.Text = "Tipo Producto: ";
            // 
            // lblProveedorProd
            // 
            this.lblProveedorProd.AutoSize = true;
            this.lblProveedorProd.Location = new System.Drawing.Point(61, 267);
            this.lblProveedorProd.Name = "lblProveedorProd";
            this.lblProveedorProd.Size = new System.Drawing.Size(81, 20);
            this.lblProveedorProd.TabIndex = 4;
            this.lblProveedorProd.Text = "Proveedor";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(167, 118);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 26);
            this.txtIdProd.TabIndex = 5;
            // 
            // txtNomProd
            // 
            this.txtNomProd.Location = new System.Drawing.Point(140, 173);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(178, 26);
            this.txtNomProd.TabIndex = 6;
            // 
            // cbTipoProd
            // 
            this.cbTipoProd.FormattingEnabled = true;
            this.cbTipoProd.Location = new System.Drawing.Point(181, 221);
            this.cbTipoProd.Name = "cbTipoProd";
            this.cbTipoProd.Size = new System.Drawing.Size(193, 28);
            this.cbTipoProd.TabIndex = 7;
            // 
            // cbProveedorProd
            // 
            this.cbProveedorProd.FormattingEnabled = true;
            this.cbProveedorProd.Location = new System.Drawing.Point(148, 267);
            this.cbProveedorProd.Name = "cbProveedorProd";
            this.cbProveedorProd.Size = new System.Drawing.Size(226, 28);
            this.cbProveedorProd.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(317, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(365, 430);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 38);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(409, 386);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 38);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.NomProd,
            this.TipProducto,
            this.ProveedorProd,
            this.precioProd});
            this.dgvProducto.Location = new System.Drawing.Point(506, 103);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowTemplate.Height = 28;
            this.dgvProducto.Size = new System.Drawing.Size(665, 233);
            this.dgvProducto.TabIndex = 12;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "Id Producto";
            this.idProd.Name = "idProd";
            // 
            // NomProd
            // 
            this.NomProd.HeaderText = "Nombre";
            this.NomProd.Name = "NomProd";
            // 
            // TipProducto
            // 
            this.TipProducto.HeaderText = "Tipo Producto";
            this.TipProducto.Name = "TipProducto";
            // 
            // ProveedorProd
            // 
            this.ProveedorProd.HeaderText = "Proveedor";
            this.ProveedorProd.Name = "ProveedorProd";
            // 
            // precioProd
            // 
            this.precioProd.HeaderText = "Precio";
            this.precioProd.Name = "precioProd";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(65, 327);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 20);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 320);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 26);
            this.txtPrecio.TabIndex = 14;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 482);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbProveedorProd);
            this.Controls.Add(this.cbTipoProd);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lblProveedorProd);
            this.Controls.Add(this.lblTipoProd);
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.lblProducto);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblNomProd;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.Label lblProveedorProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.ComboBox cbTipoProd;
        private System.Windows.Forms.ComboBox cbProveedorProd;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProd;
    }
}