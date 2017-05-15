using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }
        public Venta Venta { get; set; }

        public TipoPago()
        {

        }
    }
}
