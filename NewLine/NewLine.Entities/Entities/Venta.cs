using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public List<Evaluacion> Evaluacions { get; set; }
        public List<Contrato> Contratoes { get; set; }
        public List<TipoPago> TipoPagoes { get; set; }
        public List<LineaTelefonica> LineaTelefonicas { get; set; }
        public Cliente Cliente { get; set; }
        public CentroAtencion CentroAtencion { get; set; }

        public Venta()
        {
            Evaluacions = new List<Evaluacion>();
            Contratoes = new List<Contrato>();
            TipoPagoes = new List<TipoPago>();
            LineaTelefonicas = new List<LineaTelefonica>();
        }

        public Venta(Cliente cliente, CentroAtencion centroAtencion)
        {
            Cliente = cliente;
            CentroAtencion = centroAtencion;
        }

    }
}
