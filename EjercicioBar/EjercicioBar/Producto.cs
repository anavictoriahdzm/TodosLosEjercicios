using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBar
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public TipoProveedor tiprovedor { get; set; }
        public Proveedor nomProvedor { get; set; }
        public string precio { get; set; }

        public Producto()
        {
            this.tiprovedor = new TipoProveedor();
            this.nomProvedor = new Proveedor();
          
        }

    }
}
