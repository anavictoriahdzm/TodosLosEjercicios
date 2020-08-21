using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBar
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form Empleados = new Form1();
            Empleados.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Form Proveedores = new Form2();
            Proveedores.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form Clientes = new Form3();
            Clientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form Productos = new Form4();
            Productos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form Ventas = new Form5();
            Ventas.Show();
        }
    }
}
