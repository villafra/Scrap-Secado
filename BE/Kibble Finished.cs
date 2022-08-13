using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public class Kibble_Finished:IEntidable
    {
        public int Codigo { get; set; }
        public string Descripción { get; set; }
        public double Costo { get; set; }
        public Enumerables.Familia Familia { get; set; }
        public int Cantidad { get; set; }

        public double CalcularCosto()
        {
            return Costo * Cantidad;
        }
    }
}
