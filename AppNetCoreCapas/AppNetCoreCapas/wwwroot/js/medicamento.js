window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {

    fetchGet("Medicamento/Saludos", "text", function (res) {
        alert(res);

    })
    fetchGet("Medicamento/Numero", "text", function (res) {
        alert(res);

    })

}
