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
    public class BLL_Scrap_Secado : IGestionable<Scrap_Secado>
    {
        Mapp_Scrap_Secado MapperShare;
        public BLL_Scrap_Secado()
        {
            MapperShare = new Mapp_Scrap_Secado();
        }
        public bool Baja(Scrap_Secado KF)
        {
            return MapperShare.Baja(KF);
        }

        public bool Guardar(Scrap_Secado KF)
        {
            return MapperShare.Guardar(KF);
        }

        public List<Scrap_Secado> Listar()
        {
            return MapperShare.Listar();
        }

        public List<Scrap_Secado> Listar(string Familia)
        {
            return MapperShare.Listar(Familia);
        }

        public Scrap_Secado ListarObjeto(Scrap_Secado KF)
        {
            return MapperShare.ListarObjeto(KF);
        }
    }
}
