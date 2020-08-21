using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBar
{
    public class Ventas
    {
        public int idVenta { get; set; }
        public string mesa { get; set; }
        public string empleado { get; set; }
        public string cliente { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public List<Producto> ProductosVeendidos { get; set; }
        public int total { get; set; }
         

    }
}
