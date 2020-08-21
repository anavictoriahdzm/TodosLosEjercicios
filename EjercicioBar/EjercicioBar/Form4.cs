using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace EjercicioBar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<TipoProveedor> tiprov = new List<TipoProveedor>();
            XmlDocument xmlTipoProveedor = new XmlDocument();
            xmlTipoProveedor.Load(@"C:\Users\Curso\EjercicioBar\tipoProveedores.xml");
            tiprov.AddRange(DeserializeFromXml<List<TipoProveedor>>(xmlTipoProveedor.OuterXml));
            foreach (var item in tiprov)
            {
                cbTipoProd.Items.Add(item.tipoProveedor);
            }

            List<Proveedor> prov = new List<Proveedor>();
            XmlDocument xmlProveedor = new XmlDocument();
            xmlProveedor.Load(@"C:\Users\Curso\EjercicioBar\Proveedores.xml");
            prov.AddRange(DeserializeFromXml<List<Proveedor>>(xmlProveedor.OuterXml));
            foreach (var item in prov)
            {
                cbProveedorProd.Items.Add(item.nombreProv);
            }
        }

        public void SerializeToXml<T>(T obj, string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            //Create a filestream object connected to the target file

            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fileStream, obj);
            fileStream.Close();
        }
        public static T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<Producto> ListaProducto = new List<Producto>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Productos.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Productos.xml");
                ListaProducto.AddRange(DeserializeFromXml<List<Producto>>(Doc.OuterXml));
            }
            Producto Productos = new Producto();
            Productos.idProducto = int.Parse(txtIdProd.Text);
            Productos.nombre = txtNomProd.Text;
            Productos.tiprovedor.tipoProveedor = cbTipoProd.Text;
            Productos.nomProvedor.nombreProv = cbProveedorProd.Text;
            Productos.precio = txtPrecio.Text;

            ListaProducto.Add(Productos);
            SerializeToXml<List<Producto>>(ListaProducto, @"C:\Users\Curso\EjercicioBar\Productos.xml");
            MessageBox.Show(this, "Producto creado", "mensaje");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            txtNomProd.Text = "";
            cbTipoProd.Text = "Seleccionar";
            cbProveedorProd.Text = "Seleccionar";
            txtPrecio.Text = "";
            dgvProducto.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> ListaProducto = new List<Producto>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Productos.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Productos.xml");
                ListaProducto.AddRange(DeserializeFromXml<List<Producto>>(Doc.OuterXml));
                dgvProducto.Rows.Clear();
                foreach (var item in ListaProducto)
                {
                    if (item.idProducto == int.Parse(txtIdProd.Text))
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.idProducto });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.nombre });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.tiprovedor.tipoProveedor });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.nomProvedor.nombreProv });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.precio });
                        dgvProducto.Rows.Add(Row);

                    }
                }
            }
        }
    }
}
