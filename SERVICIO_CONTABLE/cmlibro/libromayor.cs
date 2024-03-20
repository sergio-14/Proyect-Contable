using cmlibro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cmlibro;
using cmlibro.DBTableAdapters;

namespace SERVICIO_CONTABLE
{
    internal class libromayor
    {
        public void Buscar(string cli, DB.T_MayorDataTable ds)
        {
            var adap = new T_MayorTableAdapter();
            adap.Filtrar(ds, cli);
        }
    }
}
