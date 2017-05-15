using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public List<Distrito> Distritoes { get; set; }
        public Departamento Departamento { get; set; }

        public Provincia()
        {
            Distritoes = new List<Distrito>();
        }
    }
}
