using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CartaPorteBL
    {
        public List<CartaPorteCLS> listarCartaPortes()
        {
            CartaPorteDAL obj = new CartaPorteDAL();
            return obj.listarCartaPortes();
        }
    }
}
