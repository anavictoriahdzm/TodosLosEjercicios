﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaImagen.Models
{
    public class ProductosEN
    {
        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public string Desctip { get; set; }
        public string Imagen { get; set; }

        public decimal Precio { get; set; }
    }
}