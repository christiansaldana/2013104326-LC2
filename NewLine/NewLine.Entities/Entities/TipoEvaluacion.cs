using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class TipoEvaluacion
    {
        public int TipoEvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public TipoEvaluacion()
        {

        }

    }
}
