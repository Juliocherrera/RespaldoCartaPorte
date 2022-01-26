window.onload = function () {
    listarCartaPorte();
}

function listarCartaPorte() {

    pintar({
        url: "CartaPorte/listarCartaPortes",
        cabeceras: ["Folio", "Serie", "UUID","Pdf_xml_descarga","Pdf_descargaFactura","xlm_descargaFactura","cancelFactura","LegNum","Fecha","Total","Moneda","RFC","Origen","Destino"],
        propiedades: ["Folio", "Serie", "UUID", "Pdf_xml_descarga", "Pdf_descargaFactura", "xlm_descargaFactura", "cancelFactura", "LegNum", "Fecha", "Total", "Moneda", "RFC", "Origen", "Destino"]
    })

    /*
    [
        { "idtipomedicamento": 1, "nombre": "Analgesicos", "descripcion": "Des 1" },
        { "idtipomedicamento": 2, "nombre": "Antialergicos", "descripcion": "Des 2" }
    ]
    */
    /*
    fetchGet("TipoMedicamento/listarTipoMedicamento", "json", function (res) {
     
       
       
        
        var contenido = "";
        contenido += "<table class='table'>";
        contenido += "<thead>";
        contenido += "<tr>";
        contenido += "<td>Id tipo medicamento</td>";
        contenido += "<td>Nombre</td>";
        contenido += "<td>Descripcion</td>";
        contenido += "</tr>";
        contenido += "</thead>"
        
        var nregistros = res.length;
        var obj;
        contenido += "<tbody>";
        for (var i = 0; i < nregistros; i++) {
            obj=res[i]
            contenido += "<tr>";
            contenido += "<td>" + obj.idtipomedicamento+"</td>";
            contenido += "<td>" + obj.nombre+"</td>";
            contenido += "<td>" + obj.descripcion+"</td>";
            contenido += "</tr>";
        }
        contenido+="</tbody>"
        contenido += "</table>";
        document.getElementById("divTabla").innerHTML = contenido;

 
  })
*/


}