using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocioEN
{
    public class GeneroEN
    {
        public byte Id { get; set; }
        public string TipoGenero { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
    }
}
