var cordenadas = "";
var idcmp = "";


$(document).ready(function () {
    initMap();
    $('#idbusqueda').keyup(function (e) {
        if (e.keyCode == 13) {
            verinfocompany();
        }
    });
});



function initMap() {
    const myLatlng = {
        lat: 20.558862,
        lng: -100.217417
    };
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 4,
        center: myLatlng,
        scaleControl: true,
        mapTypeControl: true,
        mapTypeControlOptions: {
            style: google.maps.MapTypeControlStyle.DROPDOWN_MENU,
            mapTypeIds: ["roadmap", "terrain"],
        },
    });

    //Create the initial InfoWindow.
    let infoWindow = new google.maps.InfoWindow({
        content: "Clic en el mapa para obtener la longitud y latitud.",
        position: myLatlng,
    });

    //const geocoder = new google.maps.Geocoder();
    //document.getElementById("submit").addEventListener("click", () => {
    //    geocodeAddress(geocoder, map);
    //});

    infoWindow.open(map);
    // Configure the click listener.
    map.addListener("click", (mapsMouseEvent) => {
        // Close the current InfoWindow.
        infoWindow.close();
        // Create a new InfoWindow.
        infoWindow = new google.maps.InfoWindow({

            position: mapsMouseEvent.latLng,
        });

        infoWindow.setContent(
            JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2)
        );
        infoWindow.open(map);

        infodir(infoWindow.position);
    });
}

function infodir(longlat) {
    $.ajax({
        url: "Default.aspx/metlatlng",
        data: "{latlng:'" + longlat + "'}",
        dataType: "json",
        type: "post",
        async: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            $("#inputlat").val(data.d[0]);
            $("#inputlng").val(data.d[1]);
        },
        error: function (data) {
        }
    });
}

function updtlatlngjs() {
    var lat = $("#inputlat").val();
    var lng = $("#inputlng").val();
    $.ajax({
        url: "Default.aspx/updtlatlng",
        data: "{lat:'" + lat + "',lng:'" + lng + "', id:'" + idcmp + "'}",
        dataType: "json",
        type: "post",
        async: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            if (data.d == "OK") {
                alert("Datos actualizados con éxito.");
                borrar();
            } else { alert("Error al actualizar datos."); }
        },
        error: function (data) {
        }
    });
}

function borrar() {
    cordenadas = "";
    idcmp = "";
    $("#inputcmp").val("");
    $("#inputdir1").val("");
    $("#inputdir2").val("");
    $("#inputdir3").val("");
    $("#inputcp").val("");
    $("#inputciudad").val("");
    $("#inputlat").val("");
    $("#inputlng").val("");
    $("#idbusqueda").val("");
}

function verinfocompany() {
    var id = $("#idbusqueda").val();
    if (id.replace(" ", "") != "") {
        $.ajax({
            url: "Default.aspx/verinfocompany",
            data: "{id:'" + id + "'}",
            dataType: "json",
            type: "post",
            async: false,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                idcmp = data.d[0];
                $("#inputcmp").val(data.d[0]);
                $("#inputdir1").val(data.d[1]);
                $("#inputdir2").val(data.d[2]);
                $("#inputdir3").val(data.d[3]);
                $("#inputcp").val(data.d[4]);
                $("#inputciudad").val(data.d[5]);
                $("#inputlat").val(data.d[6]);
                $("#inputlng").val(data.d[7]);
                $("#idbusqueda").val("");
            },
            error: function (data) {
            }
        });
    }
}


