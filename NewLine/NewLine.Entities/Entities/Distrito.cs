using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public Provincia Provincia { get; set; }

        public Distrito()
        {

        }
    }
}
