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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            List<Empleado> ListaEmpleados = new List<Empleado>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Empleados.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Empleados.xml");
                ListaEmpleados.AddRange(DeserializeFromXml<List<Empleado>>(Doc.OuterXml));
            }

            Empleado nombreEmpleado = new Empleado();

            nombreEmpleado.idEmp = int.Parse(txtIdEmp.Text);
            nombreEmpleado.nombre = txtNom.Text;
            nombreEmpleado.fechaNacimiento = dateTimePicker1.Value;
            nombreEmpleado.sexo.decSexo = cbGenero.Text;
            nombreEmpleado.puesto.nombrePuesto= txtTipoEmpl.Text;
            nombreEmpleado.puesto.decPuesto = txtDescPuesto.Text;

            ListaEmpleados.Add(nombreEmpleado);
            SerializeToXml<List<Empleado>>(ListaEmpleados, @"C:\Users\Curso\EjercicioBar\Empleados.xml");
            MessageBox.Show(this, "creado", "mensaje");

            //SerializeToXml<Empleado>(nombreEmpleado, @"C:\Users\Curso\EjercicioBar\Empleados.xml");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdEmp.Text = "";
            txtNom.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cbGenero.Text = "Selecionar";
            txtTipoEmpl.Text = "";
            txtDescPuesto.Text = "";
            dgvEmpleados.Rows.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            List<Empleado> ListaEmpleados = new List<Empleado>();
            if (File.Exists(@"C:\Users\Curso\EjercicioBar\Empleados.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:\Users\Curso\EjercicioBar\Empleados.xml");
                ListaEmpleados.AddRange(DeserializeFromXml<List<Empleado>>(Doc.OuterXml));
                dgvEmpleados.Rows.Clear();
                foreach (var item in ListaEmpleados)
                {
                    if (item.idEmp == int.Parse(txtIdEmp.Text))
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.idEmp });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.nombre });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.fechaNacimiento });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.sexo.decSexo });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.puesto.nombrePuesto });
                        Row.Cells.Add(new DataGridViewTextBoxCell { Value = item.puesto.decPuesto });
                        dgvEmpleados.Rows.Add(Row);
                    }
                }
            }
        }
    }
}
