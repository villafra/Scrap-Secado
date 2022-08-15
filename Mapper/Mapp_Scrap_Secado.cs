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

        public Mapp_Scrap_Secado()
        {
            share = new Sharepoint();
        }
        public bool Baja(Scrap_Secado KF)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(Scrap_Secado KF)
        {
            string[] query = null;
            query[0]= @"Insert into ";
            return share.EscribirTransaction(query);
        }

        public List<Scrap_Secado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Scrap_Secado> Listar(string Familia)
        {
            throw new NotImplementedException();
        }

        public Scrap_Secado ListarObjeto(Scrap_Secado KF)
        {
            throw new NotImplementedException();
        }
    }
}
