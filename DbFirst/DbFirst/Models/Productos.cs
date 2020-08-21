using System;
using System.Collections.Generic;

namespace DbFirst2.Models
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public string Imagen { get; set; }
        public decimal? Precio { get; set; }
    }
}
