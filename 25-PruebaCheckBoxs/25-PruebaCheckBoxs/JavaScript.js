function mostrar() {
    var deportes = document.getElementsByClassName("deportes");
    var texto = document.getElementById("texto");

    for (var i = 0; i < deportes.length; i++) {
        texto.innerHTML = deportes[i].value + " , ";
    }
}