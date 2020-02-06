window.onload = inicializa;

function inicializa() {
    cargarSuperheroes();
}

function cargarSuperheroes() {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:59912/api/Superheroes");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var respuesta = miLlamada.responseText;
            var arraySuperheroes = JSON.parse(respuesta);
            var data = "";
            for (var i = 0; i < arraySuperheroes.length; i++) {
                data += "<tr>"
                data += "<td><input type='checkbox' value='" + arraySuperheroes[i].IDSuperheroe + "' class='superheroes'></td>"
                data += "<td id='id' hidden>" + arraySuperheroes[i].IDSuperheroe + " </td>"
                data += "<td id='nombre'>" + arraySuperheroes[i].NombreSuperheroe + "</td>";
                data += "</tr>"
            }

            document.getElementById("forSuperheroes").innerHTML = data;
        }

    };

    miLlamada.send();

}


/*
 * Este es la funcion del boton verReservas
 */
function verReservas() {
    var superheroes = document.getElementsByClassName("superheroes"); //Esto lo usamos para recoger los datos de los checkBox
    var texto = document.getElementById("texto"); //Para escribir en el texto los resultados
    var pintarMisiones = "";
    var contadorNoSeleccionados = 0; //El contadorNoSeleccionados lo usamos cuando el usuario no ha seleccionado ese superheroe
    texto.innerHTML = "";

   for (var i = 0; i < superheroes.length; i++) {
       if (superheroes[i].checked) { //Cuando un superheroe esta marcado
           var superheroe = superheroePorID(superheroes[i].value); //Por el valor del checkBox (elegimos su id). Buscamos al superheroe por una llamada a la API
           var listMisiones = listadoMisionesSuperheroe(superheroes[i].value); //Tambien usamos el mismo valor para buscar las misiones asociadas

           if (listMisiones.length == 0) { //Si no tiene misiones le ponemos el texto de no tiene misiones
               texto.innerHTML = texto.innerHTML + " <h3> " + superheroe.NombreSuperheroe + " </h3> " + "<br/> No hay misiones asociadas a este superheroe <hr>";
           }

           else {
               for (var cont = 0; cont < listMisiones.length; cont++) { //Si las tiene
                   pintarMisiones = pintarMisiones + listMisiones[cont].TituloMision + " <br/> "; //Escribimos el titulo de las misiones
               }
               texto.innerHTML = texto.innerHTML + " <h3> " + superheroe.NombreSuperheroe + " </h3> " + "<br/>" + pintarMisiones + "<hr>";
           }
           contadorNoSeleccionados = 0; //Aqui en el caso de que haya un superheroe seleccionado volvemos la cuenta a 0
       }
       else {
           contadorNoSeleccionados++ //Si no se han seleccionado sumamos 1 a la cuenta
           if (contadorNoSeleccionados == superheroes.length) { //En el caso de que la cuenta y el tamaño de superheroes sea el mismo
               alert("Tienes que seleccionar algun superheroe"); //No se ha seleccionado ningun superheroe
               contadorNoSeleccionados = 0; //Reset de la cuenta
           }
       }

   }
    
}

/*
 * La busqueda en la api del superheroe por su id, el metodo es usado en VerReservas 
 */
function superheroePorID(id) {
    var miLlamada = new XMLHttpRequest();
    var superheroe = new Object();

    miLlamada.open("GET", "http://localhost:59912/api/Superheroes/" + id, false);

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var respuesta = miLlamada.responseText;
            superheroe = JSON.parse(respuesta);
        }

    };

    miLlamada.send();
    return superheroe;
}

/*
 * La busqueda en la api de la lista de misiones por el id del superheroe, el metodo es usado en VerReservas 
 */
function listadoMisionesSuperheroe(id) {
    var miLlamada = new XMLHttpRequest();
    var arrayMisiones;

    miLlamada.open("GET", "http://localhost:59912/api/Misiones/" + id, false);

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var respuesta = miLlamada.responseText;
            arrayMisiones = JSON.parse(respuesta);
        }

    };

    miLlamada.send();
    return arrayMisiones;
}


