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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void SerializerToXml<T>(T obj, string fileName)
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
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Asignar ID");
            }

            List<Clientes> ListaClientes = new List<Clientes>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Clientes.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Clientes.xml");
                ListaClientes.AddRange(DeserializeFromXml<List<Clientes>>(Doc.OuterXml));
            }

            Clientes infoCliente = new Clientes();
            infoCliente.idCliente = int.Parse(txtIdCliente.Text);
            infoCliente.nombreCliente = txtNomCliente.Text;
            infoCliente.fechaCliente = dateTimePicker1.Value;
            infoCliente.sexo.decSexo = cbGeneroCliente.Text;
            infoCliente.telCliente = txtTelCliente.Text;
            

            ListaClientes.Add(infoCliente);
            SerializerToXml<List<Clientes>>(ListaClientes, @"C:\Users\Curso\EjercicioBar\Clientes.xml");
            MessageBox.Show(this, "Creado", "mensaje");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = "";
            txtNomCliente.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cbGeneroCliente.Text = "Seleccionar";
            txtTelCliente.Text = "";
            txtIdCliente.Focus();
            dgvClientes.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Clientes> ListaClientes = new List<Clientes>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Clientes.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Clientes.xml");
                ListaClientes.AddRange(DeserializeFromXml<List<Clientes>>(Doc.OuterXml));
                dgvClientes.Rows.Clear();
                foreach (var item in ListaClientes)
                {
                    if (item.idCliente == int.Parse(txtIdCliente.Text))
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.idCliente });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.nombreCliente });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.fechaCliente });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.sexo.decSexo });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.telCliente });
                        dgvClientes.Rows.Add(Row);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
