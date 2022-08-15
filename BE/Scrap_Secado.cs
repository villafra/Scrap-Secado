using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public class Scrap_Secado:IEntidable
    {
        public int Codigo { get; set; }
        public DateTime FechaYHora { get; set; }
        public Enumerables.Turno Turno { get; set; }
        public string Operador { get; set; }
        public Enumerables.Equipo Equipo { get; set; }
        public Enumerables.Extrusora Extrusora { get; set; }
        public Kibble_Finished Kibble { get; set; }
        public string Motivo { get; set; }
        public double Costo_Desvío { get; set; }
        public string Comentarios { get; set; }
        public Enumerables.Periodo Periodo { get; set; }
        public Enumerables.Semana Semana { get; set; }

    }
}
