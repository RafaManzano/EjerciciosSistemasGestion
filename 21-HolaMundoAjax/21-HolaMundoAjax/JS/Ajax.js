window.onload = inicializa;

function inicializa() {
    document.getElementById("btnSaludar").addEventListener("click", saludo);
    document.getElementById("btnPedirApellido").addEventListener("click", pedirApellido);
    document.getElementById("btnBorrar").addEventListener("click", borrarPersona);
}

function saludo() {
    //alert("Todavia no, Boina");
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "../HTML/Hola.html");

    //Definicion estados
    miLlamada.onreadystatechange = function () {
        

        if (miLlamada.readyState < 4) {
            document.getElementById("divSaludo").innerHTML = "Cargando.......";
           
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                
                var respuesta = miLlamada.responseText;
                document.getElementById("divSaludo").innerHTML = respuesta;
            }

    };

    miLlamada.send();

}


function pedirApellido() {
    //alert("Todavia no, Boina");
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://crudtoflamaapi.azurewebsites.net/api/Persona");

    //Definicion estados
    miLlamada.onreadystatechange = function () {


        if (miLlamada.readyState < 4) {
            document.getElementById("divApellido").innerHTML = "Cargando.......";

        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {

                var respuesta = miLlamada.responseText;
                var arrayPersonas = JSON.parse(respuesta);
                var apellido = arrayPersonas[0].nombre;

                document.getElementById("divApellido").innerHTML = apellido;
            }

    };

    miLlamada.send();

}

function borrarPersona() {
    //alert("Todavia no, Boina");
    var miLlamada = new XMLHttpRequest();
    var numero = document.getElementById("inputNumero").value;
    miLlamada.open("DELETE", "https://crudtoflamaapi.azurewebsites.net/api/Persona/" + numero);

    //Definicion estados
    miLlamada.onreadystatechange = function () {


        if (miLlamada.readyState < 4) {
            //document.getElementById("btnBorrar").innerHTML = "Cargando.......";

        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 204) {
                alert("Persona eliminada con exito");
            }

    };

    miLlamada.send();

}