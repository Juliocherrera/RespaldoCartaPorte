using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class TipoMedicamentoBL
    {
        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            TipoMedicamentoDAL obj = new TipoMedicamentoDAL();
            return obj.listarMedicamentos();
        }
    }
}
