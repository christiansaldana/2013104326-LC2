using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public List<Ubigeo> Ubigeoes { get; set; }

        public Direccion()
        {
            Ubigeoes = new List<Ubigeo>();
        }
    }
}
