using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            XmlTextReader xtr = new XmlTextReader(@"C:\Users\Curso\EjercicioBar\Clientes1.xml");

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Clientes1")
                {
                    //if (txtSearch.Text == "idCliente")
                    //{
                    //    string Clientes = xtr.ReadElementString();
                    //    lvResult.Items.Add("Name= " + Clientes);
                    //}
                    string Clientes1 = xtr.ReadElementString();
                    lvResult.Items.Add("Name= " + Clientes1);
                }
            }
        }
    }
}
