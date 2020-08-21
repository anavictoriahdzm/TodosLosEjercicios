using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBar
{
    public class Proveedor
    {
        public int id { get; set; }
        public string nombreProv { get; set; }
        public string telefono { get; set; }
        public string producto { get; set; }
        public TipoProveedor tipoDeProveedor { get; set; } 
        public Proveedor()
        {
            this.tipoDeProveedor = new TipoProveedor();
        }

        
        public string RFC { get; set; }
    }
}
