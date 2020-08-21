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


namespace UIForms
{
    public partial class Form1 : Form
    {
        
        public Form1()    

        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = Prueba();
            Refrescar();
            //Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            //this.dataGridView1.AutoGenerateColumns = false;
            using (NorthwindEntities ModelGame = new NorthwindEntities())
            {
                var lst = from d in ModelGame.Products
                          where d.CategoryID == 9 || d.CategoryID == 10
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }


        //public List<Products> Prueba()
        //{
        //    using (NorthwindEntities ModelGame = new NorthwindEntities())
        //    {
        //        List<Products> lst = new List<Products>();
        //        foreach (var item in ModelGame.Products.ToList())
        //        {
        //            if (item.CategoryID == 9 || item.CategoryID ==  10)
        //            {
        //                Products p = new Products();
        //                p.CategoryID = item.CategoryID.Value;
        //                p.Discontinued = item.Discontinued;
        //                p.ProductID = item.ProductID;
        //                p.ProductName = item.ProductName;
        //                p.QuantityPerUnit = item.QuantityPerUnit;
        //                p.ReorderLevel = item.ReorderLevel;
        //                p.SupplierID = item.SupplierID;
        //                p.UnitPrice = item.UnitPrice;
        //                p.UnitsInStock = item.UnitsInStock;
        //                p.UnitsOnOrder = item.UnitsOnOrder;
        //                lst.Add(p);
        //            }
        //        }

        //        return lst;
                
        //    }
        //}

        private int? GetID()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null; 
            }
            
        }
        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Presentacion.FrmAgregar oFrmAgregar = new Presentacion.FrmAgregar();
            oFrmAgregar.ShowDialog();

            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? ProductID = GetID();
            if (ProductID != null)
            {
                Presentacion.FrmAgregar oFrmAgregar = new Presentacion.FrmAgregar(ProductID);
                oFrmAgregar.ShowDialog();

                Refrescar();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int? ProductID = GetID();
            if (ProductID != null)
            {
                using (NorthwindEntities db = new NorthwindEntities())
                {
                    Products oProduct = db.Products.Find(ProductID);
                    db.Products.Remove(oProduct);

                    db.SaveChanges();
                }
                Refrescar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentacion.FrmAgregar oFrmAgregar = new Presentacion.FrmAgregar();
            oFrmAgregar.ShowDialog();

            Refrescar();
        }
    }
}
