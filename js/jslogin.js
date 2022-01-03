
$('#inputEmail').keypress(function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == '13') {
        validalog();
        e.preventDefault();
        return false;
    }
});

$('#inputPassword').keypress(function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == '13') {
        validalog();
        e.preventDefault();
        return false;
    }
});



$('#inputPassword1').keypress(function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == '13') {
        UpdatePass();
        e.preventDefault();
        return false;
    }
});

$('#inputPassword2').keypress(function (e) {
    var keycode = (e.keyCode ? e.keyCode : e.which);
    if (keycode == '13') {
        UpdatePass();
        e.preventDefault();
        return false;
    }
});

// Obtener referencia a botón
// Recuerda: el numeral o # indica id

const botonlog = document.querySelector("#btnlogusu");
// Agregar listener
botonlog.addEventListener("click", function (evento) {
    // Aquí todo el código que se ejecuta cuando se da click al botón
    validalog();
});

const botonActPass = document.querySelector("#btnupdpass");
// Agregar listener
botonActPass.addEventListener("click", function (evento) {
    // Aquí todo el código que se ejecuta cuando se da click al botón
    UpdatePass();
});

$(document).ready(function () {
    $("#divbuscar").hide();
});

function validalog() {
    var usu = $("#inputEmail").val();
    var pass = $("#inputPassword").val();
    if (usu != "" && pass != "") {
        $.ajax({
            url: "Login.aspx/valida",
            data: "{user:'" + usu + "', pass:'" + pass + "'}",
            dataType: "json",
            type: "post",
            async: false,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d[0] == "Error") {
                    Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                   text: 'El Usuario o Password son Invalidos'
 
});
                }
                else {
                    //window.location = "CartaPorte.aspx";
                    $(location).attr('href', "CartaPorte.aspx");
                    //document.location.href = 'CartaPorte.aspx';
                }
            },
            error: function (data) {
            }
        });
    } else
    {
        Swal.fire({
          icon: 'error',
          title: 'Oops...',
          text: 'Favor de Validar Usuario y Contraseña'
        });
    }
}




function UpdatePass() {
    var pass1 = $("#inputPassword1").val();
    var pass2 = $("#inputPassword2").val();
    var usu = $("#inputEmail").val();
    if (pass1 == pass2 && usu != "" ) {
        $.ajax({
            url: "Login.aspx/updatepass",
            data: "{user:'" + usu + "', pass1:'" + pass1 + "', pass2:'" + pass2 + "'}",
            dataType: "json",
            type: "post",
            async: false,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d == "Error") {
                    alert("El usuario o contraseña son invalidos...");
                }
                else {

                }
            },
            error: function (data) {
            }
        });
    } else {
        alert("Favor de validar su usuario o contraseña...");
    }
}
