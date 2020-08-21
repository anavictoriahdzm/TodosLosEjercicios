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
    public partial class FrmGames : Form
    {
        public int? ProductID;
        Products oProduct = null;
        public FrmGames(int? productID = null)
        {
            InitializeComponent();
            this.ProductID = productID;
            if (ProductID != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                oProduct = db.Products.Find(ProductID);
                txtProductID.Text = oProduct.ProductID.ToString();
                txtProdName.Text = oProduct.ProductName;
                txtSupplierID.Text = oProduct.SupplierID.ToString();
                txtCateID.Text = oProduct.CategoryID.ToString();
                txtQUnit.Text = oProduct.QuantityPerUnit;
                txtUStock.Text = oProduct.UnitsInStock.ToString();
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
                oProduct.ProductName = txtProdName.Text;
                oProduct.SupplierID = int.Parse(txtSupplierID.Text);
                oProduct.CategoryID = int.Parse(txtCateID.Text);
                oProduct.QuantityPerUnit = txtQUnit.Text;
                oProduct.UnitPrice = decimal.Parse(txtPrice.Text);
                oProduct.UnitsInStock = short.Parse(txtUStock.Text);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (string.IsNullOrEmpty(this.txtProductID.Text))
                {
                    MessageBox.Show("Ingrese id del producto");
                }
                else
                {
                    int id = int.Parse(this.txtProductID.Text);
                    var Producto = db.Products
                        .Where(P => P.ProductID == id).FirstOrDefault();
                    if (Producto == null)
                    {
                        MessageBox.Show("No hay resultaods");
                    }
                    else
                    {
                        this.txtProductID.Text = Producto.ProductID.ToString();
                        this.txtProdName.Text = Producto.ProductName;
                        this.txtSupplierID.Text = Producto.SupplierID.ToString();
                        this.txtCateID.Text = Producto.CategoryID.ToString();
                        this.txtQUnit.Text = Producto.QuantityPerUnit;
                        this.txtPrice.Text = Producto.UnitPrice.ToString();
                        this.txtUStock.Text = Producto.UnitsInStock.ToString();
                        this.txtUOrder.Text = Producto.UnitsOnOrder.ToString();
                        this.txtReorder.Text = Producto.ReorderLevel.ToString();
                        this.cbDiscontinued.Checked = Producto.Discontinued;
                    }
                }
            }
        }
    }
}
