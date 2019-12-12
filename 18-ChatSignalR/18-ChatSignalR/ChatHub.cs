using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace _18_ChatSignalR
{
    public class ChatHub : Hub
    {
        /// <summary>
        /// Con este metodo se envia a todos los clientes los mensajes
        /// </summary>
        /// <param name="name">Nombre del mensaje</param>
        /// <param name="message">Cuerpo del mensaje</param>
        /*
        public void Send(clsMensaje mensaje)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(mensaje);
        }
        */

        public void Send(string name, string mensaje)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, mensaje);
        }
    }
}