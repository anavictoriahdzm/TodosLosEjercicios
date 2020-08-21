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
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (NorthwindEntities ModelGame = new NorthwindEntities())
            {
                var lst = from d in ModelGame.Products
                          where d.CategoryID == 9 || d.CategoryID == 10
                          select d;
                dgvData.DataSource = lst.ToList();
            }
        }

        private int? GetID()
        {
            try
            {
                return int.Parse(dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Presentacion.FrmGames oFrmGames = new Presentacion.FrmGames();
            oFrmGames.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? ProductID = GetID();
            if (ProductID != null)
            {
                Presentacion.FrmGames oFrmGames = new Presentacion.FrmGames(ProductID);
                oFrmGames.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Ojo aquí, prros");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
            Presentacion.FrmGames oFrmGames = new Presentacion.FrmGames();
            oFrmGames.ShowDialog();
            Refrescar();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
