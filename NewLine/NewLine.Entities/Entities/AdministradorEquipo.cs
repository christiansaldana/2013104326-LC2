using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class AdministradorEquipo
    {
        public int AdministradorEquipoId { get; set; }
        public List<EquipoCelular> EquipoCelulars { get; set; }

        public AdministradorEquipo()
        {
            EquipoCelulars = new List<EquipoCelular>();
        }
    }
}
