using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class CartaPorteDAL
    {
        public List<CartaPorteCLS> listarCartaPortes()
        {
            List<CartaPorteCLS> lista = null;
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            var bd = root.GetConnectionString("cn");
            using (SqlConnection cn = new SqlConnection(bd))
            {
                try
                {
                    cn.Open();
                    //Con esto ejecutamos un procedimiento almacenado o una consulta select
                    using(SqlCommand cmd=new SqlCommand("SELECT TOP 25 Folio, Serie, UUID, Pdf_xml_descarga, Pdf_descargaFactura, replace(xml_descargaFactura,'}','') as xml_descargaFactura, replace(cancelFactura,'}','') as cancelFactura, LegNum, Fecha, Total, Moneda, RFC,Origen, Destino FROM RESPALDO_Carta_Porte ORDER BY FECHA DESC", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        //Con esto ejecuto esta consulta
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null)
                        {
                            CartaPorteCLS oCartaPorteCLS;
                            lista = new List<CartaPorteCLS>();
                            while (drd.Read())
                            {
                                oCartaPorteCLS = new CartaPorteCLS();
                                oCartaPorteCLS.Folio = drd.GetString(0);
                                oCartaPorteCLS.Serie = "<a href='https://www.google.com'><button type='button' class='btn btn-primary'>"+drd.GetString(1) + "</button></a>";
                                oCartaPorteCLS.UUID = drd.GetString(2);
                                lista.Add(oCartaPorteCLS);
                            }
                            cn.Close();
                        }
                    }
                }
                catch(Exception e)
                {
                    cn.Close();
                    lista = null;
                }
                
            }
                return lista;
        }
            /*
            //Aqui vamos a crear un metodo para listar los medicamentos de la capa de entidades

                //Aqui llenamos la lista
                List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
                //Lista 1
                lista.Add(new TipoMedicamentoCLS 
                {
                    idtipomedicamento=1, 
                    nombre="Analgesicos",
                    descripcion = "Des 1"
                });
                //Lista 2
                lista.Add(new TipoMedicamentoCLS
                {
                    idtipomedicamento = 2,
                    nombre = "Antialergicos",
                    descripcion = "Des 2"
                });
                return lista;
            }
            */

        }
}
