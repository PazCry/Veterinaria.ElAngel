﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocioEN
{
    public class ClienteEN
    {
        public byte Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public long Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
