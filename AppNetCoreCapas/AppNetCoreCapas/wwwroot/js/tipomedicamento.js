window.onload = function () {
    listarTipoMedicamento();
}

function listarTipoMedicamento() {

    pintar({
        url: "TipoMedicamento/listarTipoMedicamento",
        cabeceras: ["Id tipo medicamento", "Nombre", "Descripcion"],
        propiedades: ["idtipomedicamento", "nombre", "descripcion"]
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