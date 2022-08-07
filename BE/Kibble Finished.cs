using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Kibble_Finished
    {
        public int Codigo { get; set; }
        public string Descripción { get; set; }
        public Enumerables.Familia Familia { get; set; }
        public Enumerables.Extrusora Extrusora { get; set; }
        public int Cantidad { get; set; }
        public Enumerables.Turno Turno { get; set; }
        public string Operador { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }
        public Enumerables.Periodo Periodo { get; set; }
        public Enumerables.Semana Semana { get; set; }


        public string PeriodoPxWx()
        {
            return Periodo.ToString() + Semana.ToString();
        }
    }
}
