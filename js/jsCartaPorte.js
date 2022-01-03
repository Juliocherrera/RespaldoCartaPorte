$('#txtSearch').keypress(function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == '13') {
        var buscar = $("#txtSearch").val();
        validacarta(buscar);
        e.preventDefault();
        return false;
    }
});




const botonActPass = document.querySelector("#btnbuscarleg");
// Agregar listener
botonActPass.addEventListener("click", function (evento) {
    // Aquí todo el código que se ejecuta cuando se da click al botón
    var buscar = $("#txtSearch").val(); 
    validacarta(buscar);
});


$(document).ready(function () {
    $("#cargando").hide();
    var queryString = window.location.search;
    var urlParams = new URLSearchParams(queryString);
    var leg = urlParams.get('leg');
    validacarta(leg);
    vertblcartaporte();
});


function validacarta(leg) {
    
	if (leg>0)
    {
	   $("#cargando").show();
    }
    
    $.ajax({
        url: "CartaPorte.aspx/valida",
        data: "{leg:'" + leg + "'}",
        dataType: "json",
        type: "post",
        async: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
	
            if (data.d[0] == "Error") {
                //alert(data.d[1]);
				Swal.fire({
                 icon: 'error',
                 title: 'Oops...',
                 html: '<p>' + data.d[1] + '</p>'
                });
            }
            else if (data.d[0] == "Error1")
            {
                //alert(data.d[1]);
				Swal.fire({
                 icon: 'error',
                 title: 'Oops...',
                 html: '<p>' + data.d[1] + '</p>'
                });
            }
            else if ((data.d[0] != "Error1") || (data.d[0] != "Error") || (data.d[0] != "Error3") ) {
				leg = "";
                Swal.fire({
                 position: 'top-end',
                 icon: 'success',
                 title: 'Se Timbro Correctamente la Carta Porte',
                showConfirmButton: false,
               timer: 1500
               });
			   vertblcartaporte();
                $("#inputleg").val(leg);
                $("#inputtipo").val("TDRXP");
                $("#inputfecha").val(data.d[0]);
                $("#inputsubtotal").val(data.d[1]);
                $("#inputTotalimptrasl").val(data.d[2]);
                $("#inputTotalimpreten").val(data.d[3]);
                $("#inputDescuentos").val(data.d[4]);
                $("#inputTotal").val(data.d[5]);
                $("#inputFormaPago").val(data.d[6]);
                $("#inputCondipago").val(data.d[7]);
                $("#inputMetodoPago").val(data.d[8]);
                $("#inputMoneda").val(data.d[9]);
                $("#inputRFC").val(data.d[10]);
                $("#inputCodSAT").val(data.d[11]);
                $("#inputIdProducto").val(data.d[12]);
                $("#inputProducto").val(data.d[13]);
                $("#inputOrigen").val(data.d[14]);
                $("#inputDestino").val(data.d[15]);
                $("#txtSearch").val("");
                
               
            }
            $("#cargando").hide();
        },
        error: function (data) {
        }
    });
}

function cancelCP(urlcancel, leg){
 var texto = urlcancel
var requestOptions = {
  method: 'POST',
  mode: 'no-cors',
  redirect: 'follow'
};

Swal.fire({
  title: 'Cancelar Carta Porte ' + leg +' ?',
  text: "Esta accion no podra ser revertida!",
  icon: 'warning',
  showCancelButton: true,
  confirmButtonColor: '#3085d6',
  cancelButtonColor: '#d33',
  confirmButtonText: 'Si, cancelar!'
}).then((result) => {
  if (result.isConfirmed) {
    fetch(texto, requestOptions)
    .then(response => response.text())
    .then(result => Swal.fire({
     position: 'top-end',
     icon: 'success',
     title: "Carta Porte " + leg + " Cancelada",
     showConfirmButton: false,
     timer: 2500
     }))
  .catch(error => Swal.fire("Error no se pudo cancelar la Carta Porte " + leg));
	
	
  }
})

}


function vertblcartaporte() {
    var t = $("#tabledataCPD").DataTable(
        {
            destroy: true,
            responsive: true,
            ajax: {
                method: "POST",
                url: "CartaPorte.aspx/gettable",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: function (d) {
                    return JSON.stringify(d);
                },
                dataSrc: "d.data"
            }, error: function (data) {
                $("#tabledataCPD").fn.dataTable.ext.errMode = 'throw';
            },
            columns: [
                { "data": "Folio" },
                { "data": "Serie" },
                { "data": "UUID" },
				{ "data": "Pdf_xml_descarga" },
                { "data": "Pdf_descargaFactura" },
                { "data": "xlm_descargaFactura" },
                { "data": "cancelFactura" },
                { "data": "LegNum" },
                { "data": "Fecha" },
                { "data": "Total" },
                { "data": "Moneda" },
                { "data": "RFC" },
				{ "data": "Origen" },
				{ "data": "Destino" }
				
            ],
			"order": [[ 0, "desc" ]],
                        "pageLength":100
			
        });
}