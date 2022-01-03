
$(document).ready(function () {
    //verinfocompany();
    verdirecciones();
    //$('#tabledata').DataTable();
});


//function verinfocompany() {
//    $.ajax({
//        url: "DatosCompany.aspx/datacompany",
//        data: "{}",
//        dataType: "json",
//        type: "post",
//        async: false,
//        contentType: "application/json; charset=utf-8",
//        success: function (data) {
//            var result = data.d;
//            $("#datatable1").replaceWith("<tbody id='datatable1'>" + result + "</tbody>");
//        },
//        error: function (data) {
//        }
//    });
//}


function verdirecciones() {
    var t = $("#tabledata").DataTable(
        {
            destroy: true,
            responsive: true,
            ajax: {
                method: "POST",
                url: "DatosCompany.aspx/gettable",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: function (d) {
                    return JSON.stringify(d);
                },
                dataSrc: "d.data"
            }, error: function (data) {
                $("#tabledata").fn.dataTable.ext.errMode = 'throw';
            },
            columns: [
                { "data": "ID" },
                { "data": "Dir1" },
                { "data": "Dir2" },
                { "data": "Dir3" },
                { "data": "cp" },
                { "data": "Ciudad" },
                { "data": "lat" },
                { "data": "lng" }
            ]
        });
}


