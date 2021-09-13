// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var campoFiltro = document.querySelector("#filtrar-tabela");

campoFiltro.addEventListener("input", function () {
    var pacientes = document.querySelectorAll(".paciente");

    if (this.value.length > 0) {
        for (i = 0; i < pacientes.length; i++) {
            var paciente = pacientes[i];

            var tdNome = paciente.querySelector(".info-nome");
            var nome = tdNome.textContent;

            var expressao = new RegExp(this.value, "i");

            if (expressao.test(nome)) {
                paciente.classList.remove("invisivel");
            } else {
                paciente.classList.add("invisivel");
            }

        }
    } else {
        for (i = 0; i < pacientes.length; i++) {
            var paciente = pacientes[i];
            paciente.classList.remove("invisivel");

        }
    }

});