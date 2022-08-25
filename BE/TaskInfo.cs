using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE
{
    public class TaskInfo
    {
        public Form Father { get; set; }
        public Form Son { get; set; }
        public int hilo { get; set; }
        public int maximo { get; set; }
        public int malos { get; set; }
        public string Fecha { get; set; }
        public string mensaje { get; set; }
    }
}
