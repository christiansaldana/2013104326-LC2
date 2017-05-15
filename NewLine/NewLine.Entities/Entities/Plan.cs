using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }

        public List<TipoPlan> TipoPlans { get; set; }

        public Plan()
        {
            TipoPlans = new List<TipoPlan>();
        }

    }
}
