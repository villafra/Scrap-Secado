using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatización
{
    public static class MarsCalendar
    {
        private static string inicio = @"S:\public\Base de Datos\Inicio.dat";
        private static DateTime inicioDate;
        public static string MarsPxWx(DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 28);
            double semana = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 7) - (periodo - 1) * 4;
            return $"P{periodo.ToString().PadLeft(2, '0')}W{semana}";
        }

        public static string MarsPx(DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 28);
            return $"P{periodo.ToString().PadLeft(2, '0')}";
        }

        public static string MarsWx(DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 28);
            double semana = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 7) - (periodo - 1) * 4;
            return $"W{semana}";
        }

        public static string MarsWeekNumber(DateTime calculo)
        {
            double semana = Math.Ceiling((calculo.Date.ToOADate() - inicioDate.Date.ToOADate()) / 7);
            return $"{semana.ToString().PadLeft(2, '0')}";
        }

        public static string MarsLote(DateTime calculo, int turnos)
        {
            string año = inicioDate.AddDays(7).Year.ToString().Substring(inicioDate.AddDays(7).Year.ToString().Length - 1, 1);
            string semana = MarsWeekNumber(calculo);
            string dia = Dia(calculo);
            string turno = Turno(turnos);
            return $"{año}{semana}{dia}{turno}MER";
        }
        private static string Dia(DateTime dia)
        {
            int dias = (int)dia.DayOfWeek;
            string[] Día = new string[] { "G", "A", "B", "C", "D", "E", "F" };

            return $"{Día[dias]}";

        }

        private static string Turno(int turnos)
        {
            int ahora = DateTime.Now.Hour;
            string turno = null;

            if (turnos == 2)
            {
                if (ahora >= 6 && ahora < 18) //=IF(H1>=14;IF(H1<22;"T";"N");IF(H1<6;"N";"M"))
                {
                    turno = "M";
                }
                else if (ahora >= 18 || ahora < 6)
                {
                    turno = "N";
                }
            }
            if (turnos == 3)
            {
                if (ahora >= 6 && ahora < 14) //=IF(H1>=14;IF(H1<22;"T";"N");IF(H1<6;"N";"M"))
                {
                    turno = "M";
                }
                else if (ahora >= 14 && ahora < 22)
                {
                    turno = "T";
                }
                else
                {
                    turno = "N";
                }
            }

            return turno;
        }

        public static void CambiarFechaInicio(DateTime fechainicio)
        {
            FileStream fs = new FileStream(inicio, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter escritor = new StreamWriter(fs))
            {
                escritor.WriteLine(fechainicio.ToString("dd/MM/yyyy"));
            }
        }
        public static bool FechaInicio (DateTime hoy)
        {
            DateTime fechainicio;
            FileStream fs = new FileStream(inicio, FileMode.Open, FileAccess.Read);
            using (StreamReader lector = new StreamReader(fs))
            {
                fechainicio = DateTime.Parse(lector.ReadLine());
            }
            return fechainicio.Year.Equals(hoy.Year);
        }

        public static void CargarFechaInicio()
        {
            FileStream fs = new FileStream(inicio, FileMode.Open, FileAccess.Read);
            using (StreamReader lector = new StreamReader(fs))
            {
                inicioDate = DateTime.Parse(lector.ReadLine());
            }
           
        }
    }
}
