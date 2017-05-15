using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class LineaTelefonica
    {
        public int LineaTelefonicaId { get; set; }
        public List<TipoLinea> TipoLineas { get; set; }
        public AdministradorLinea AdministradorLinea { get; set; }
        public Venta Venta { get; set; }

        public LineaTelefonica()
        {
            TipoLineas = new List<TipoLinea>();
        }
    }
}
