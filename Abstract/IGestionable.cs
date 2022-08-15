using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IGestionable<T> where T : IEntidable
    {
        bool Guardar(T KF);
        bool Baja(T KF);
        List<T> Listar();
        List<T> Listar(string Familia);
        T ListarObjeto(T KF);
    }
}
