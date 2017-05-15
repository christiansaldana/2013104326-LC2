using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public List<EstadoEvaluacion> EstadoEvaluacions { get; set; }
        public List<TipoEvaluacion> TipoEvaluacions { get; set; }
        public List<EquipoCelular> EquipoCelulars { get; set; }
        public Venta Venta { get; set; }
        public Trabajador Trabajador { get; set; }
        public Plan Plan { get; set; }
        public Cliente Cliente { get; set; }       
        public LineaTelefonica LineaTelefonica { get; set; }
        public CentroAtencion CentroAtencion { get; set; }


        public Evaluacion()
        {
            EstadoEvaluacions = new List<EstadoEvaluacion>();
            TipoEvaluacions = new List<TipoEvaluacion>();
            EquipoCelulars = new List<EquipoCelular>();
        }

        public Evaluacion(Plan plan, Cliente cliente, Trabajador trabajador, LineaTelefonica lineaTelefonica, CentroAtencion centroAtencion)
        {
            Plan = plan;
            Cliente = cliente;
            Trabajador = trabajador;
            LineaTelefonica = lineaTelefonica;
            CentroAtencion = centroAtencion;
        }

    }
}
