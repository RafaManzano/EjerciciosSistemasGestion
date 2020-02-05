window.onload = inicializa;

function inicializa() {
    cargarPersonasConDepartamentos();
    //document.getElementById("btnInsertar").addEventListener("click", crearModalInsertar, false);
}

function cargarPersonasConDepartamentos() {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://localhost:44361/api/Departamentos");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var arrayDepartamentos = JSON.parse(miLlamada.responseText);
            cargarPersonas(arrayDepartamentos);
        }
    };

    miLlamada.send();
}

function cargarPersonas(arrayDepartamentos) {
    //alert("Todavia no, Boina");
    var cargarPersonasCall = new XMLHttpRequest();


    cargarPersonasCall.open("GET", "https://localhost:44361/api/Personas");

    //Definicion estados
    cargarPersonasCall.onreadystatechange = function () {


        if (cargarPersonasCall.readyState < 4) {
            //document.getElementById("btnBorrar").innerHTML = "Cargando.......";

        }
        else
            if (cargarPersonasCall.readyState == 4 && cargarPersonasCall.status == 200) {
                //alert("Persona eliminada con exito");
                var respuesta = cargarPersonasCall.responseText;
                var arrayPersonas = JSON.parse(respuesta);
                var data = "";
                for (var i = 0; i < arrayPersonas.length; i++) {

                    for (var c = 0; c < arrayDepartamentos.length; c++) {
                        if (arrayDepartamentos[c].id == arrayPersonas[i].idDepartamento)
                            var nombreDpto = arrayDepartamentos[c].nombre;
                    }
                    data += "<tr>"
                    data += "<td id='id' hidden>" + arrayPersonas[i].idPersona + " </td>"
                    data += "<td id='nombre'>" + arrayPersonas[i].nombre + "</td>";
                    data += "<td id='apellidos'>" + arrayPersonas[i].apellidos + "</td>";
                    data += "<td id='fecha'>" + arrayPersonas[i].fechaNacimiento + "</td>";
                    data += "<td id='direccion'>" + arrayPersonas[i].direccion + "</td>";
                    data += "<td id='telefono'>" + arrayPersonas[i].telefono + "</td>";
                    data += "<td id='foto'>" + arrayPersonas[i].foto + "</td>";
                    data += "<td id='nombreDpto'>" + nombreDpto + "</td>";
                    data += '<td> ' +
                        //'<button id="editar">Editar</button>'
                        '<input type="image" id="' + arrayPersonas[i].idPersona + '" src="../IMG/edit.jpg" width="30" heigth="30" onclick="crearModalEditar(' + arrayPersonas[i].idPersona + ')">' +
                        '<input type="image" id="' + arrayPersonas[i].idPersona + '" src="../IMG/delete.png" width="30" heigth="30" onclick="crearModalEliminar(' + arrayPersonas[i].idPersona + ')">' +
                        '</td>';
                    data += "</tr>"
                }

                document.getElementById("forPersonas").innerHTML = data;
            }

    };

    cargarPersonasCall.send();

}

function crearModalInsertar() {
    var crear = document.getElementById("modalCrear");
    var btnCrear = document.getElementById("botonCrear");
    var btnCancelar = document.getElementById("botonCancelar");
    crear.style.display = "block";

    btnCrear.onclick = function () {
        var op = new Object();
        op.idPersona = 0;
        op.nombre = document.getElementById("nombreA").value;
        op.apellidos = document.getElementById("apellidosA").value;
        op.fechaNacimiento = document.getElementById("fechaNacimientoA").value;
        op.direccion = "";
        op.telefono = document.getElementById("telefonoA").value;
        op.idDepartamento = document.getElementById("idDepartA").value;

        insertarPersona(op);
        crear.style.display = "none";
    }

    btnCancelar.onclick = function () {
        crear.style.display = "none";
    }
}

function insertarPersona(persona) {
    var insertar = new XMLHttpRequest();
    insertar.open("POST", "https://localhost:44361/api/Personas", false);
    insertar.setRequestHeader('Content-type', 'application/json');

    var json = JSON.stringify(persona);

    // Definicion estados
    insertar.onreadystatechange = function () {

        if (insertar.readyState < 4) {

        }
        else
            if (insertar.readyState == 4 && insertar.status == 204) {

                alert("Persona insertada con exito");
                //crear.style.display = "none";
            }
    };

    insertar.send(json);
}

function crearModalEditar(id) {
    var editar = document.getElementById("modalEditar");
    var btnEditar = document.getElementById("botonConfirmar");
    var btnCancelar = document.getElementById("botonCancelarEditar");
    editar.style.display = "block";
    var pers = buscarPersonaPorID(id);

    //Establecemos todos los campos
    document.getElementById("nombreE").setAttribute("value", pers.nombre);
    document.getElementById("apellidosE").setAttribute("value", pers.apellidos);
    document.getElementById("telefonoE").setAttribute("value", pers.telefono);
    document.getElementById("fechaNacimientoE").setAttribute("value", pers.fechaNacimiento);
    document.getElementById("idDepartE").value = pers.idDepartamento;

    btnEditar.onclick = function () {
        var op = new Object();
        op.idPersona = id;
        op.nombre = document.getElementById("nombreE").value;
        op.apellidos = document.getElementById("apellidosE").value;
        op.fechaNacimiento = document.getElementById("fechaNacimientoE").value;
        op.direccion = "";
        op.telefono = document.getElementById("telefonoE").value;
        op.idDepartamento = document.getElementById("idDepartE").value;

        editarPersona(op);

        editar.style.display = "none";
    }

    btnCancelar.onclick = function () {
        crear.style.display = "none";
    }
}

function editarPersona(persona) {
    var editar = new XMLHttpRequest();
    editar.open("PUT", "https://localhost:44361/api/Personas", false);
    editar.setRequestHeader('Content-type', 'application/json');

    var json = JSON.stringify(persona);

    // Definicion estados
    editar.onreadystatechange = function () {

        if (editar.readyState < 4) {

        }
        else
            if (editar.readyState == 4 && editar.status == 204) {

                alert("Persona actualizada con exito");
                //crear.style.display = "none";
            }
    };

    editar.send(json);
}

function crearModalEliminar(id) {
    var eliminar = document.getElementById("modalEliminar");
    var btnEliminar = document.getElementById("AceptarEliminar");
    var btnCancelarEliminar = document.getElementById("CancelarEliminar");
    eliminar.style.display = "block";


    btnEliminar.onclick = function () {
        eliminarPersona(id);
        //Despues de usar este modal no recarga la pagina automaticamente, asi que habria que recargar la pagina manualmente
        //o crear un metodo que lo recargue automaticamente

        eliminar.style.display = "none";
    }

    btnCancelarEliminar.onclick = function () {
        eliminar.style.display = "none";
    }
}

function eliminarPersona(id) {
    var eliminarLlamada = new XMLHttpRequest();
    eliminarLlamada.open("DELETE", "https://localhost:44361/api/Personas/" + id, false);
        eliminarLlamada.onreadystatechange = function () {

            if (eliminarLlamada.readyState < 4) {

            }
            else
                if (eliminarLlamada.readyState == 4 && eliminarLlamada.status == 204) {
                    alert("Persona eliminada correctamente");
                }
        };
        eliminarLlamada.send();
}

function buscarPersonaPorID(id) {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://localhost:44361/api/Personas/" + id, false);
    var persona = new Object();

    //Definicion estados
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {

        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                persona = JSON.parse(miLlamada.responseText);
            }
    };

    miLlamada.send();
    return persona;
}



    