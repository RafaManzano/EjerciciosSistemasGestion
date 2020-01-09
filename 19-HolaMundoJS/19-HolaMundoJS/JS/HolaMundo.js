window.onload = inicializa;

function inicializa() {
    //Anhadir evento click al boton Pulsar y que cambie el texto
    document.getElementById("btnPulsar").addEventListener("click", cambiarTexto, false);
}

function cambiarTexto() {
    document.getElementById("divTexto").innerHTML = "HolaMundo";
}