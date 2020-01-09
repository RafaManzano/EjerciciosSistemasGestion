//import Persona from '../JS/clsPersona';
window.onload = inicializa;

class Persona {
    constructor(nombre, apellidos) {
        this.nombre = nombre;
        this.apellidos = apellidos;
    }

    get getNombre() {
        return this.nombre;
    };
    get getApellidos() {
        this.apellidos;
    };
}

function inicializa() {
    //Anhadir evento click al boton Pulsar y que cambie el texto
    document.getElementById("btnMostrar").addEventListener("click", mostrarPersona, false);
}

function mostrarPersona() {
    var nombre = document.getElementById("blNombre");
    var apellidos = document.getElementById("blApellidos");
    var persona = new Persona(nombre, apellidos);
    document.getElementById("mostrarPersona").innerHTML = "Esta persona se llama " + persona.getNombre + persona.getApellidos;
}