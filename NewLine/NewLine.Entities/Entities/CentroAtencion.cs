using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }
        public List<Ubigeo> Ubigeoes { get; set; }

        public CentroAtencion()
        {
            Ubigeoes = new List<Ubigeo>();
        }
    }
}
