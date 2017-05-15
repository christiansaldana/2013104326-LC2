using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; }

        public Venta Venta { get; set; }

        public Contrato()
        {

        }

    }
}
