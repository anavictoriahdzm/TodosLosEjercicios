using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIForms.Model;

namespace UIForms.Presentacion
{
    public partial class FrmAgregar : Form
    {
        public int? ProductID;
        Products oProduct = null;
        public FrmAgregar(int? ProductID = null)
        {
            InitializeComponent();
            this.ProductID = ProductID;
            if (ProductID != null)
                CargarDatos();
        }

        private void CargarDatos()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                oProduct = db.Products.Find(ProductID);
                txtProductID.Text = oProduct.ProductID.ToString();
                txtProductName.Text = oProduct.ProductName;
                txtSupplierID.Text = oProduct.SupplierID.ToString();
                txtCategoryID.Text = oProduct.CategoryID.ToString();
                txtQuantity.Text = oProduct.QuantityPerUnit;
                txtPrice.Text = oProduct.UnitPrice.ToString();
                txtStock.Text = oProduct.UnitsInStock.ToString();
                txtUOrder.Text = oProduct.UnitsOnOrder.ToString();
                txtReorder.Text = oProduct.ReorderLevel.ToString();
                cbDiscontinued.Checked = oProduct.Discontinued;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (ProductID == null)
                    oProduct = new Products();

                oProduct.ProductID = int.Parse(txtProductID.Text);
                oProduct.ProductName = txtProductName.Text;
                oProduct.SupplierID = int.Parse(txtSupplierID.Text);
                oProduct.CategoryID = int.Parse(txtCategoryID.Text);
                oProduct.QuantityPerUnit = txtQuantity.Text;
                oProduct.UnitPrice = decimal.Parse(txtPrice.Text);
                oProduct.UnitsInStock = short.Parse(txtStock.Text);
                oProduct.UnitsOnOrder = short.Parse(txtUOrder.Text);
                oProduct.ReorderLevel = short.Parse(txtReorder.Text);
                oProduct.Discontinued = cbDiscontinued.Checked;

                if (ProductID == null)
                    db.Products.Add(oProduct);
                else
                {
                    db.Entry(oProduct).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (string.IsNullOrEmpty(this.txtProductName.Text))
                {
                    MessageBox.Show("Ingresa nombre del producto");
                }
                else
                {
                    var Producto = db.Products
                        .Where(P => P.ProductName == this.txtProductName.Text).FirstOrDefault();
                    if (Producto == null)
                    {
                        MessageBox.Show("No hay resultados");
                    }
                    else
                    {
                        this.txtProductID.Text = Producto.ProductID.ToString();
                        this.txtProductName.Text = Producto.ProductName;
                        this.txtSupplierID.Text = Producto.SupplierID.ToString();
                        this.txtCategoryID.Text = Producto.CategoryID.ToString();
                        this.txtQuantity.Text = Producto.QuantityPerUnit;
                        this.txtPrice.Text = Producto.UnitPrice.ToString();
                        this.txtStock.Text = Producto.UnitsInStock.ToString();
                        this.txtUOrder.Text = Producto.UnitsOnOrder.ToString();
                        this.txtReorder.Text = Producto.ReorderLevel.ToString();
                        this.cbDiscontinued.Checked = Producto.Discontinued;
                    }
                }

            }
        }
    }
}