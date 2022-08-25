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
    public class MAPP_KF : IGestionable<Kibble_Finished>
    {
        DataBase Acceso, AccesoShare;
        public bool Baja(Kibble_Finished KF)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(Kibble_Finished KF)
        {
            throw new NotImplementedException();
        }

        public List<Kibble_Finished> Listar()
        {
            Acceso = new DataBase();
            string query = "Select [Código], [Descripcion], [Costo], [Familia] from Recetas inner join Familias on [Recetas].ID_Familia=[Familias].ID where Activo=true";
            List<Kibble_Finished> ListadeKF = new List<Kibble_Finished>();
            DataTable Dt = Acceso.DevolverListado(query, null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    Kibble_Finished KF = new Kibble_Finished();
                    KF.Codigo = Convert.ToInt32(row[0].ToString());
                    KF.Descripción = row[1].ToString();
                    KF.Costo = Convert.ToDouble(row[2].ToString());
                    KF.Familia = (Enumerables.Familia)Enum.Parse(typeof(Enumerables.Familia), row[3].ToString());
                    ListadeKF.Add(KF);
                }
            }
            return ListadeKF;
        }

        public List<Kibble_Finished> Listar(string Familia)
        {
            Acceso = new DataBase();
            string query = "Select [Código], [Descripcion], [Costo], [Familia] from Recetas inner join Familias on [Recetas].ID_Familia=[Familias].ID where Activo=true and Familia = '" + Familia + "'";
            List<Kibble_Finished> ListadeKF = new List<Kibble_Finished>();
            DataTable Dt = Acceso.DevolverListado(query, null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    Kibble_Finished KF = new Kibble_Finished();
                    KF.Codigo = Convert.ToInt32(row[0].ToString());
                    KF.Descripción = row[1].ToString();
                    KF.Costo = Convert.ToDouble(row[2].ToString());
                    KF.Familia = (Enumerables.Familia)Enum.Parse(typeof(Enumerables.Familia), row[3].ToString());
                    ListadeKF.Add(KF);
                }
            }
            return ListadeKF;
        }
        public Kibble_Finished ListarObjeto(Kibble_Finished KF)
        {
            throw new NotImplementedException();
        }
        public Kibble_Finished ListarKF (int codigo)
        {
            AccesoShare = new DataBase();
            string query = "Select [Código], [Descripcion], [Costo], [Familia] from Recetas inner join Familias on [Recetas].ID_Familia=[Familias].ID where Activo=true and [Código]=" + codigo;
            DataTable Dt = AccesoShare.DevolverListado(query, null);
            Kibble_Finished KF = new Kibble_Finished();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    
                    KF.Codigo = Convert.ToInt32(row[0].ToString());
                    KF.Descripción = row[1].ToString();
                    KF.Costo = Convert.ToDouble(row[2].ToString());
                    KF.Familia = (Enumerables.Familia)Enum.Parse(typeof(Enumerables.Familia), row[3].ToString());
                }
            }
            return KF;
        }
    }
}
