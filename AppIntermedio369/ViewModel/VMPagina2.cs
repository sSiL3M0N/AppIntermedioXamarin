using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AppIntermedio369.Model;

namespace AppIntermedio369.ViewModel
{
    public class VMPagina2 : BaseViewModel
    {
        #region VARIABLES

        private string _Num1;
        public List<MUsuario> listaUsuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            this.Navigation = navigation;

            listaUsuarios = new List<MUsuario>
            {
                new MUsuario() { Nombre = "Erlin", Imagen = "imagen.ong" },
                new MUsuario() { Nombre = "Jorge", Imagen = "imagen.ong" },
                new MUsuario() { Nombre = "Raul", Imagen = "imagen.ong" },
                new MUsuario() { Nombre = "Emily", Imagen = "imagen.ong" }
            };

        }
        #endregion

        #region OBJECTOS

        public string Num1 { 
            get=> _Num1;
            set => SetValue(ref _Num1, value);
        }

        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
            await Navigation.PopAsync();
        }

        public async void ProcesoSimple()
        {
        }

        public async Task SeleccionaItem(MUsuario listaUsuarios) {
            await DisplayAlert("-", $"{ listaUsuarios.Nombre }", "---");
        }
        #endregion

        #region COMANDOS
        public ICommand Volver => new Command(async () => await ProcesoAsyncrono());
        public ICommand Seleccionar => new Command<MUsuario>(async (p) => await SeleccionaItem(p));
        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion
    }
}
