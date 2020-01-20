window.onload = inicializa;
var editar;
var anhadir;
var eliminar;

function inicializa() {
    document.getElementById("anhadir").addEventListener("click", introducirPersona);
    document.getElementById("editar").addEventListener("click", clickarEditar);
    cargarPersonasConDepartamentos();
    editar = document.getElementById("editEmployeeModal");
    anhadir = document.getElementById("addEmployeeModal");
    eliminar = document.getElementById("deleteEmployeeModal");
    //document.getElementById("btnPedirApellido").addEventListener("click", pedirApellido);
    //document.getElementById("btnBorrar").addEventListener("click", borrarPersona);
}

function cargarPersonasConDepartamentos() {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://crudtoflamaapi.azurewebsites.net/api/Departamento");

    //Definición del estado
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
    var miLlamada = new XMLHttpRequest();
    
    
    miLlamada.open("GET", "https://crudtoflamaapi.azurewebsites.net/api/Persona/");

    //Definicion estados
    miLlamada.onreadystatechange = function () {


        if (miLlamada.readyState < 4) {
            //document.getElementById("btnBorrar").innerHTML = "Cargando.......";

        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                //alert("Persona eliminada con exito");
                var respuesta = miLlamada.responseText;
                var arrayPersonas = JSON.parse(respuesta);
                var data = "";
                for (var i = 0; i < arrayPersonas.length; i++) {
                    
                    for (var c = 0; c < arrayDepartamentos.length; c++) {
                        if (arrayDepartamentos[c].id == arrayPersonas[i].idDepartamento)
                            var nombreDpto = arrayDepartamentos[c].nombre;
                    }
                    data += "<tr>"
                    data += "<td id='id' hidden>" + arrayPersonas[i].idPersona + " </td>"
                    data +="<td id='nombre'>" + arrayPersonas[i].nombre + "</td>";
                    data +="<td id='apellidos'>" + arrayPersonas[i].apellidos + "</td>";
                    data +="<td id='fecha'>" + arrayPersonas[i].fechaNacimiento + "</td>";
                    data += "<td id='direccion'>" + arrayPersonas[i].direccion + "</td>";
                    data += "<td id='telefono'>" + arrayPersonas[i].telefono + "</td>";
                    data += "<td id='foto'>" + arrayPersonas[i].foto + "</td>";
                    data += "<td id='nombreDpto'>" + nombreDpto + "</td>";
                    data += '<td> ' +
                        //'<button id="editar">Editar</button>'
                        '<i class="material-icons" data-toggle="tooltip" title="Editar" id="editar" onclick="clickarEditar(' + arrayPersonas[i].idPersona + ')">&#xE254;</i>' +
                        '<a id="borrar" href="#deleteEmployeeModal" class="delete" data-toggle="modal"><i class="material-icons" data-toggle="tooltip" title="Delete" >&#xE872;</i></a>' +
                        '</td>';
                    data += "</tr>"
                }
                
                document.getElementById("tablaPersonas").innerHTML = data;
            }

    };

    miLlamada.send();

}

function introducirPersona() {
    var insertar = new XMLHttpRequest();
    insertar.open("POST", "https://crudtoflamaapi.azurewebsites.net/api/Persona", false);
    insertar.setRequestHeader('Content-type', 'application/json');

    /*
     * for (var c = 0; c < arrayDepartamentos.length; c++) {
        if (arrayDepartamentos[c].nombre == document.getElementById("nombreDptoA").innerText)
            var nombreDpto = arrayDepartamentos[c].nombre;
        var idDpto = arrayDepartamentos[c].id;
    }
    */

    var persona = new Object();
    persona.nombre = document.getElementById("nombreA").value;
    persona.apellidos = document.getElementById("apellidosA").value;
    persona.fechaNacimiento = document.getElementById("fechaA").value;
    persona.direccion = document.getElementById("direccionA").value;
    persona.telefono = document.getElementById("telefonoA").value;
    persona.foto = document.getElementById("fotoA").value;
    persona.idDepartamento = 1;
    //persona.nombreDpto = nombreDpto;
    //persona.idDepartamento = idDpto;

    var json = JSON.stringify(persona);

    // Definicion estados
    insertar.onreadystatechange = function () {

        if (insertar.readyState < 4) {

            
        }
        else
            if (insertar.readyState == 4 && insertar.status == 204) {

                alert("Persona insertada con exito");
            }
    };

    insertar.send(json);
}


function clickarEditar(id) {
    var guardar = document.getElementById("guardarE");
    var persona = new Object();
    persona = buscarPersonaPorID(id);
    //document.getElementById("idE").value = persona.id;
    document.getElementById("nombreE").value = persona.nombre;
    document.getElementById("apellidosE").value = persona.apellidos;
    document.getElementById("fechaE").value = persona.fechaNacimiento;
    document.getElementById("direccionE").value = persona.direccion;
    document.getElementById("telefonoE").value = persona.telefono;
    document.getElementById("fotoE").value = persona.foto;
    document.getElementById("nombreDptoE").value = persona.nombreDpto;

    guardar.onclick = function () {
        var nuevaPersona = new Object();
        nuevaPersona.id = id;
        nuevaPersona.nombre = document.getElementById("nombreE").value;
        nuevaPersona.apellidos = document.getElementById("apellidosE").value;
        nuevaPersona.fechaNacimiento = document.getElementById("fechaE").value;
        nuevaPersona.direccion = document.getElementById("direccionE").value;
        nuevaPersona.telefono = document.getElementById("telefonoE").value;
        nuevaPersona.foto = document.getElementById("fotoE").value;
        nuevaPersona.idDepartamento = 1;

        var editarLlamada = new XMLHttpRequest();
        editarLlamada.open("PUT", "https://crudtoflamaapi.azurewebsites.net/api/Persona" + id, false);
        editarLlamada.setRequestHeader('Content-type', 'application/json');

        var json = JSON.stringify(nuevaPersona);

        //Definicion estados
        editarLlamada.onreadystatechange = function () {

            if (editarLlamada.readyState < 4) {


            }
            else
                if (editarLlamada.readyState == 4 && editarLlamada.status == 200) {

                    alert("Persona actualizada con exito");
                    editar.style.display = "none";

                }
        };

        editarLlamada.send(json);

    }

    /*
     * Esto es para la foto
    var img = document.createElement('img');
    img.src = "data:image/jpg;base64," + listadoPersonas[i][this.col[j]];
    img.height = 30;
    img.width = 30;
    tabCell.appendChild(img);
    */

    editar.style.display = "block";
   
}


function cancelarEditar() {
    editar.style.display = "none";
}


function buscarPersonaPorID(id) {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://crudtoflamaapi.azurewebsites.net/api/Persona/" + id, false);
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


