using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class TipoPlan
    {
        public int TipoPlanId { get; set; }
        public Plan Plan { get; set; }

        public TipoPlan()
        {

        }

    }
}
