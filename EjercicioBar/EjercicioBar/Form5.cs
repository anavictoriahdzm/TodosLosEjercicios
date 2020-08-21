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

namespace EjercicioBar
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        double total = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Empleado> emp = new List<Empleado>();
            XmlDocument xmlEmpleadoVenta = new XmlDocument();
            xmlEmpleadoVenta.Load(@"C:\Users\Curso\EjercicioBar\Empleados.xml");
            emp.AddRange(DeserializeFromXml<List<Empleado>>(xmlEmpleadoVenta.OuterXml));
            foreach (var item in emp)
            {
                cbEmpVen.Items.Add(item.nombre);
            }

            List<Clientes> clien = new List<Clientes>();
            XmlDocument xmlClientesVenta = new XmlDocument();
            xmlClientesVenta.Load(@"C:\Users\Curso\EjercicioBar\Clientes.xml");
            clien.AddRange(DeserializeFromXml<List<Clientes>>(xmlClientesVenta.OuterXml));
            foreach (var item in clien)
            {
                cbClienVen.Items.Add(item.nombreCliente);
            }

            List<Producto> prod = new List<Producto>();
            XmlDocument xmlProductoVenta = new XmlDocument();
            xmlProductoVenta.Load(@"C:\Users\Curso\EjercicioBar\Productos.xml");
            prod.AddRange(DeserializeFromXml<List<Producto>>(xmlProductoVenta.OuterXml));
            foreach (var item in prod)
            {
                cbProdVen.Items.Add(item.precio + " - " + item.nombre);
            }

            List<Mesas> mesaVenta = new List<Mesas>();
            XmlDocument xmlMeseas = new XmlDocument();
            xmlMeseas.Load(@"C:\Users\Curso\EjercicioBar\Mesas.xml");
            mesaVenta.AddRange(DeserializeFromXml<List<Mesas>>(xmlMeseas.OuterXml));
            foreach (var item in mesaVenta)
            {
                cbMesas.Items.Add(item.mesas);
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

        //boton que agrega del cobobox producto al list view
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = txtCant.Text != "" ? int.Parse(txtCant.Text) : 1;
            //int cantidad = int.Parse(txtCant.Text);
            for (int i=1; i<=cantidad; i++)
            {
                lvVenta.Items.Add(cbProdVen.Text);
            }
            
        }

        //Hace la suma de los precios de los productos del list view
        private void btnTotal_Click(object sender, EventArgs e)
        {
            String[] renglones = new string[50];

            int i = 0;
            foreach (var item in lvVenta.Items)
            {
                string precio = item.ToString().Substring(15, 2);
                precio.Trim();//Trim elimina los espacios en blanco

                renglones[i] = precio;
                total = total + int.Parse(precio);
            }
            txtTotal.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdVenta.Text = "";
            cbMesas.Text = "";
            cbEmpVen.Text = "Seleccionar";
            cbClienVen.Text = "Seleccionar";
            cbProdVen.Text = "Seleccionar";
            txtCant.Text = "";
            lvVenta.Items.Clear();
            txtTotal.Text = "";
        }

        private void btnGuardarVen_Click(object sender, EventArgs e)
        {
            List<Ventas> VentasProd = new List<Ventas>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Ventas.xml")) 
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\Curso\EjercicioBar\Ventas.xml");
                VentasProd.AddRange(DeserializeFromXml<List<Ventas>>(doc.OuterXml));
            }
            Ventas venta = new Ventas();
            venta.idVenta = int.Parse(txtIdVenta.Text);
            venta.mesa = cbMesas.Text;
            venta.empleado = cbEmpVen.Text;
            venta.cliente = cbClienVen.Text;
            venta.producto = cbProdVen.Text;
            venta.cantidad = int.Parse(txtCant.Text);
            //venta.ProductosVeendidos = 
            venta.total = int.Parse(txtTotal.Text);

            VentasProd.Add(venta);
            SerializeToXml<List<Ventas>>(VentasProd, @"C:\Users\Curso\EjercicioBar\Ventas.xml");
            MessageBox.Show("Venta guardada", "Mensaje");


        }
    }
}
