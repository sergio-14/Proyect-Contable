using SERVICIO_CONTABLE.BDTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO_CONTABLE
{
    internal class tmayor
    {
        public void Buscar(string cli, BD.T_MayorDataTable ds)
        {
            var adap = new T_MayorTableAdapter();
            adap.Filtrar(ds, cli);
        }

        public void MostrarMoto(BD.T_MayorDataTable ds)
        {
            var adap = new T_MayorTableAdapter();

            try
            {
                adap.Fill(ds);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
            }
        }
    }
}
