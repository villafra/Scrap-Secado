using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatización
{
    public static class MarsCalendar
    {
        public static string MarsPxWx(DateTime diabase, DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 28);
            double semana = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 7) - (periodo - 1) * 4;
            return $"P{periodo.ToString().PadLeft(2, '0')}W{semana}";
        }

        public static string MarsPx(DateTime diabase, DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 28);
            return $"P{periodo.ToString().PadLeft(2, '0')}";
        }

        public static string MarsWx(DateTime diabase, DateTime calculo)
        {
            double periodo = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 28);
            double semana = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 7) - (periodo - 1) * 4;
            return $"W{semana}";
        }

        public static string MarsWeekNumber(DateTime diabase, DateTime calculo)
        {
            double semana = Math.Ceiling((calculo.Date.ToOADate() - diabase.Date.ToOADate()) / 7);
            return $"{semana.ToString().PadLeft(2, '0')}";
        }

        public static string MarsLote(DateTime diabase, DateTime calculo, int turnos)
        {
            string año = diabase.AddDays(7).Year.ToString().Substring(diabase.AddDays(7).Year.ToString().Length - 1, 1);
            string semana = MarsWeekNumber(diabase, calculo);
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
    }
}
