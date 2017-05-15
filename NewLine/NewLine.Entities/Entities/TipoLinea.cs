using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class TipoLinea
    {
        public int TipoLineaId { get; set; }
        public LineaTelefonica LineaTelefonica { get; set; }

        public TipoLinea()
        {

        }
    }
}
