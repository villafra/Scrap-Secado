using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using BE;
using DAL;


namespace Mapper
{
    public class Mapp_Scrap_Secado : IGestionable<Scrap_Secado>
    {
        Sharepoint share;
        public bool Baja(Scrap_Secado KF)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(Scrap_Secado KF)
        {
            string[] query = new string[5];
            query[0] = @"Insert into [Scrap Secado] ([Fecha], [Turno], [Operador], [Equipo], [Extrusora], [Codigo KF], [Descripcion], [Motivo], [Comentarios], [Costo], [Periodo], [Semana])
                        values('" + KF.FechaYHora.ToString() + "','" + KF.Turno.ToString() + "','" + KF.Operador + "','" + KF.Equipo.ToString() + "','" + KF.Extrusora.ToString() 
                        + "'," + KF.Kibble.Codigo + ",'" + KF.Kibble.ToString() + "','" + KF.Motivo + "','" + KF.Comentarios +"', @Costo,'" + KF.Periodo.ToString() + "','" + KF.Semana.ToString() + "')";
            share = new Sharepoint();
            return share.EscribirTransaction(query, KF.Costo_Desvío);
        }

        public List<Scrap_Secado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Scrap_Secado> Listar(string Periodo)
        {
            share = new Sharepoint();
            string query = @"Select [ID], [Fecha], [Turno], [Operador], [Equipo], [Extrusora], [Codigo KF], [Descripcion], [Motivo], [Comentarios], [Costo], [Periodo], [Semana] from [Scrap Secado] where [Periodo]= '" + Periodo + "'";
            List<Scrap_Secado> list = new List<Scrap_Secado>();
            DataTable Dt = share.DevolverListado(query, null);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    Scrap_Secado scrap = new Scrap_Secado();
                    scrap.Codigo = Convert.ToInt32(row[0].ToString());
                    scrap.FechaYHora = Convert.ToDateTime(row[1].ToString());
                    scrap.Turno = (Enumerables.Turno)Enum.Parse(typeof(Enumerables.Turno), row[2].ToString());
                    scrap.Operador = row[3].ToString();
                    scrap.Equipo = (Enumerables.Equipo)Enum.Parse(typeof(Enumerables.Equipo), row[4].ToString());
                    scrap.Extrusora = (Enumerables.Extrusora)Enum.Parse(typeof(Enumerables.Extrusora), row[5].ToString());
                    scrap.Motivo = row[8].ToString();
                    scrap.Comentarios = row[9].ToString();
                    scrap.Costo_Desvío = Convert.ToDouble(row[10].ToString());
                    scrap.Periodo = (Enumerables.Periodo)Enum.Parse(typeof(Enumerables.Periodo), row[11].ToString());
                    scrap.Semana = (Enumerables.Semana)Enum.Parse(typeof (Enumerables.Semana), row[12].ToString());
                    MAPP_KF mAPP_KF = new MAPP_KF();
                    scrap.Kibble = mAPP_KF.ListarKF(Convert.ToInt32(row[6].ToString()));
                    list.Add(scrap);
                }
            }
            return list;
        }

        public Scrap_Secado ListarObjeto(Scrap_Secado KF)
        {
            throw new NotImplementedException();
        }
    }
}
