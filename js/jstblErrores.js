
$(document).ready(function () {
    vertblerror();
    $('#tabledatacp').DataTable().order([0, 'desc']).draw();
    $("#divbuscar").hide();
});




function vertblerror() {
    var table = $("#tabledatacp").DataTable(
        {
            destroy: true,
            responsive: true,
            ajax: {
                method: "POST",
                url: "TblErrores.aspx/gettable",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: function (d) {
                    return JSON.stringify(d);
                },
                dataSrc: "d.data"
            }, error: function (data) {
                $("#tabledatacp").fn.dataTable.ext.errMode = 'throw';
            },
           
            columns: [
                { "data": "Fecha" },
                { "data": "Folio" },
                { "data": "Erro1" },
                { "data": "Erro2" },
                { "data": "Erro3" },
                { "data": "Erro4" },
                { "data": "Erro5" },
                { "data": "Erro6" },
                { "data": "Erro7" }
            ]
        });
    
}
