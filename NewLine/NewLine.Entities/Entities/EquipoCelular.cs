using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class EquipoCelular
    {
        public int EquipoCelularId { get; set; }
        public Evaluacion Evaluacion { get; set; }
        public AdministradorEquipo AdministradorEquipo { get; set; }

        public EquipoCelular()
        {

        }
    }
}
