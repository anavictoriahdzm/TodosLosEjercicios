﻿using System;
using System.Collections.Generic;

namespace DbFirst1.Models
{
    public partial class Alumnos
    {
        public int Idalumnos { get; set; }
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Direccion { get; set; }
    }
}
