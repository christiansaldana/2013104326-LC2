using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class AdministradorLinea
    {
        public int AdministradorLineaId { get; set; }
        public List<LineaTelefonica> LineaTelefonicas { get; set; }

        public AdministradorLinea()
        {
            LineaTelefonicas = new List<LineaTelefonica>();
        }
    }
}
