using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_KF : IGestionable<Kibble_Finished>
    {
        MAPP_KF Mapper;

        public BLL_KF()
        {
            Mapper = new MAPP_KF();
        } 

        public bool Baja(Kibble_Finished KF)
        {
            return Mapper.Baja(KF);
        }

        public bool Guardar(Kibble_Finished KF)
        {
            return Guardar(KF);
        }

        public List<Kibble_Finished> Listar()
        {
            return Mapper.Listar();
        }

        public Kibble_Finished ListarObjeto(Kibble_Finished KF)
        {
            return Mapper.ListarObjeto(KF);
        }
    }
}
