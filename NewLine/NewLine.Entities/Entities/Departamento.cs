using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public List<Provincia> Provincias { get; set; }

        public Departamento()
        {
            Provincias = new List<Provincia>();
        }
    }
}
