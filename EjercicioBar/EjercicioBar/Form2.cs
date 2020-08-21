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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<TipoProveedor> tiprov = new List<TipoProveedor>();
            //TipoProveedor tProveedor = new TipoProveedor();
            //tProveedor.tipoProveedor = "Comida";
            //tiprov.Add(tProveedor);
            //tProveedor = new TipoProveedor();
            //tProveedor.tipoProveedor = "Bebidas";
            //tiprov.Add(tProveedor);

            //SerializeToXml<List<TipoProveedor>>(tiprov, @"C:\Users\Curso\EjercicioBar\tipoProveedores.xml");

            XmlDocument xmlTipoProveedor = new XmlDocument();
            xmlTipoProveedor.Load(@"C:\Users\Curso\EjercicioBar\tipoProveedores.xml");
            tiprov.AddRange(DeserializeFromXml<List<TipoProveedor>>(xmlTipoProveedor.OuterXml));           

            foreach (var item in tiprov)
            {
                cbTipoProveedor.Items.Add(item.tipoProveedor);
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
            List<Proveedor> ListaProveedores = new List<Proveedor>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Proveedores.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Proveedores.xml");
                ListaProveedores.AddRange(DeserializeFromXml<List<Proveedor>>(Doc.OuterXml));
            }

            Proveedor Proveedores = new Proveedor();
            Proveedores.id = int.Parse(txtIdProv.Text);
            Proveedores.nombreProv = txtNomProv.Text;
            Proveedores.telefono = txtTelProv.Text;
            Proveedores.producto = txtProductoProv.Text;
            Proveedores.tipoDeProveedor.tipoProveedor = cbTipoProveedor.Text;
            Proveedores.RFC = txtRFCProv.Text;

            ListaProveedores.Add(Proveedores);
            SerializeToXml<List<Proveedor>>(ListaProveedores, @"C:\Users\Curso\EjercicioBar\Proveedores.xml");
            MessageBox.Show(this, "Proveedor creado", "mensaje");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProv.Text = "";
            txtIdProv.Focus();
            txtNomProv.Text = "";
            txtTelProv.Text = "";
            txtProductoProv.Text = "";
            cbTipoProveedor.Text = "Seleccionar";
            txtRFCProv.Text = "";
            dgvProv.Rows.Clear();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Proveedor> ListaProveedores = new List<Proveedor>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Proveedores.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Proveedores.xml");
                ListaProveedores.AddRange(DeserializeFromXml<List<Proveedor>>(Doc.OuterXml));
                //dgvProv.DataSource = ListaProveedores;
                dgvProv.Rows.Clear();
                foreach (var item in ListaProveedores)
                {

                   
                    if (item.id == int.Parse(txtIdProv.Text))
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.id });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.nombreProv });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.telefono });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.producto });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.tipoDeProveedor.tipoProveedor });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.RFC });
                        dgvProv.Rows.Add(Row);
                    }
                    //else
                    //{
                    //    MessageBox.Show(this, "no se encuentra nada", "Mensaje");
                    //}

                }



                //if (txtIdProv.Text != "")
                //{
                //    dgvProv.CurrentCell = null;
                //    foreach (DataGridViewRow r in dgvProv.Rows)
                //    {
                //        r.Visible = false;
                //    }
                //    foreach (DataGridViewRow r in dgvProv.Rows)
                //    {
                //        foreach (DataGridViewCell c in r.Cells)
                //        {
                //            if ((c.Value.ToString().ToUpper().IndexOf(txtIdProv.Text.ToUpper())) == 0)
                //            {
                //                r.Visible = true;
                //                break;
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("No encontrado");
                //}
            }
        }
    }
}
