﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }
        public List<TipoTrabajador> TipoTrabajadors { get; set; }

        public Trabajador()
        {
            TipoTrabajadors = new List<TipoTrabajador>();
        }
    }
}
