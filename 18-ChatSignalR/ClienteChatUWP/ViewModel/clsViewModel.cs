using ClienteChatUWP.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace ClienteChatUWP.ViewModel
{
    public class clsViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Propiedades privadas
        private DelegateCommand comandoEnviar;
        private ObservableCollection<clsMensaje> listaMensajes;
        private clsMensaje miMensaje;
        private HubConnection conn;
        private IHubProxy proxy;

        #endregion

        #region Propiedades publicas
        public DelegateCommand ComandoEnviar
        {
            get
            {
                return comandoEnviar;
            }
            
            set
            {
                comandoEnviar = value;
            }
        }

        public ObservableCollection<clsMensaje> ListaMensaje
        {
            get
            {
                return listaMensajes;
            }

            set
            {
                listaMensajes = value;
            }
        }

        public clsMensaje MiMensaje
        {
            get
            {
                return miMensaje;
            }

            set
            {
                miMensaje = value;
            }
        }
        #endregion

        #region Constructores
        public clsViewModel()
        {
            //TODO try Catch
            conn = new HubConnection("https://chatsignalrderafa.azurewebsites.net");
            proxy = conn.CreateHubProxy("ChatHub");
            conn.Start();
            comandoEnviar = new DelegateCommand(Enviar);
            miMensaje = new clsMensaje();
            listaMensajes = new ObservableCollection<clsMensaje>();

            proxy.On<string, string>("broadcastMessage", mostrarMensaje);
        }

        
        #endregion

        #region Metodos
        private async void mostrarMensaje(string name, string message)
        {
            
            clsMensaje mensaje = new clsMensaje();
            mensaje.Nombre = name;
            mensaje.Mensaje = message;
            //listaMensajes.Add(mensaje);
            
            
            await Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                listaMensajes.Add(mensaje);
            });
            
        }

        private void Enviar()
        {
            proxy.Invoke("Send", miMensaje.Nombre, miMensaje.Mensaje);
        }
        #endregion


    }
}
