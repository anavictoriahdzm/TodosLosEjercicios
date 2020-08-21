namespace UIForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity_Per_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reorder_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discontinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Supplier_ID,
            this.Category_ID,
            this.Quntity_Per_Unit,
            this.Unit_Price,
            this.Units_Stock,
            this.Units_Order,
            this.Reorder_Level,
            this.Discontinued});
            this.dataGridView1.Location = new System.Drawing.Point(23, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(113, 582);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 55);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(345, 582);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 55);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(587, 582);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 55);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(807, 582);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(192, 55);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Product_ID
            // 
            this.Product_ID.DataPropertyName = "ProductID";
            this.Product_ID.HeaderText = "ProductID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "ProductName";
            this.Product_Name.HeaderText = "ProductName";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Supplier_ID
            // 
            this.Supplier_ID.DataPropertyName = "SupplierID";
            this.Supplier_ID.HeaderText = "SupplierID";
            this.Supplier_ID.Name = "Supplier_ID";
            this.Supplier_ID.ReadOnly = true;
            // 
            // Category_ID
            // 
            this.Category_ID.DataPropertyName = "CategoryID";
            this.Category_ID.HeaderText = "CategoryID";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            // 
            // Quntity_Per_Unit
            // 
            this.Quntity_Per_Unit.DataPropertyName = "QuantityPerUnit";
            this.Quntity_Per_Unit.HeaderText = "QuantityPerUnit";
            this.Quntity_Per_Unit.Name = "Quntity_Per_Unit";
            this.Quntity_Per_Unit.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.DataPropertyName = "UnitPrice";
            this.Unit_Price.HeaderText = "UnitPrice";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Units_Stock
            // 
            this.Units_Stock.DataPropertyName = "UnitsInStock";
            this.Units_Stock.HeaderText = "UnitsInStock";
            this.Units_Stock.Name = "Units_Stock";
            this.Units_Stock.ReadOnly = true;
            // 
            // Units_Order
            // 
            this.Units_Order.DataPropertyName = "UnitsOnOrder";
            this.Units_Order.HeaderText = "UnitsOnOrder";
            this.Units_Order.Name = "Units_Order";
            this.Units_Order.ReadOnly = true;
            // 
            // Reorder_Level
            // 
            this.Reorder_Level.DataPropertyName = "ReorderLevel";
            this.Reorder_Level.HeaderText = "ReorderLevel";
            this.Reorder_Level.Name = "Reorder_Level";
            this.Reorder_Level.ReadOnly = true;
            // 
            // Discontinued
            // 
            this.Discontinued.DataPropertyName = "Discontinued";
            this.Discontinued.HeaderText = "Discontinued";
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 665);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity_Per_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reorder_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discontinued;
    }
}

