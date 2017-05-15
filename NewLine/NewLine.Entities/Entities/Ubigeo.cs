using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Ubigeo
    {
        public int UbigeoId { get; set; }
        public Direccion Direccion { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public Distrito Distrito { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }

        public Ubigeo()
        {

        }
       
        public Ubigeo(Distrito distrito, Provincia provincia, Departamento departamento)
        {
            Distrito = distrito;
            Provincia = provincia;
            Departamento = departamento;
        }



    }
}
