using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBar
{
    public class Empleado
    {
        public int idEmp { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public TipoEmpleado tipoEmpleado { get; set; }
        public TipoEmpleado puesto { get; set; }
        public Sexo sexo { get; set; }

        public Empleado()
        {
            this.sexo = new Sexo();
            this.puesto = new TipoEmpleado();
        }
   
    }
}
