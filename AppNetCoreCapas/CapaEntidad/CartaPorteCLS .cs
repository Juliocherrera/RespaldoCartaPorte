using System;

namespace CapaEntidad
{
    public class CartaPorteCLS
    {
        public string Folio { get; set; }
        public string Serie { get; set; }
        public string UUID { get; set; }
        public string Pdf_xml_descarga { get; set; }
        public string Pdf_descargaFactura { get; set; }
        public string xlm_descargaFactura { get; set; }
        public string cancelFactura { get; set; }
        public string LegNum { get; set; }
        public DateTime Fecha { get; set; }
        public string Total { get; set; }
        public string Moneda { get; set; }
        public string RFC { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

    }
}
