using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBar
{
    public class Clientes
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaCliente { get; set; }
        public Sexo sexo { get; set; }
        public string telCliente { get; set; }


        public Clientes()
        {
            this.sexo = new Sexo();
        }

    }
}
