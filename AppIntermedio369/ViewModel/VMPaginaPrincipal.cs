using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AppIntermedio369.Model;
using AppIntermedio369.View;

namespace AppIntermedio369.ViewModel
{
    public class VMPaginaPrincipal:BaseViewModel
    {
        #region VARIABLES
        public List<MPaginaPrincipal> ListaPaginas { get; set; }
        string _Num1;
        #endregion

        #region CONSTRUCTOR
        public VMPaginaPrincipal(INavigation navigation)
        {
            this.Navigation = navigation;
            ListaPaginas = new List<MPaginaPrincipal> { 

                new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"},
                  new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"},
                  new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"},
                  new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"},
                  new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"},
                  new MPaginaPrincipal{Nombre="Entry, DatePicker, Picker, Label, Navegación",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="CollectionView sin enlace a Base De Datos",Icono="imagen.ong"},
                new MPaginaPrincipal{Nombre="Pokemon CRUD",Icono="imagen.ong"}

            };
        }
        #endregion

        #region OBJECTOS
        public string Num1
        {
            get { return _Num1; }
            set { SetValue(ref _Num1, value); }
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono(MPaginaPrincipal p)
        {
            string palabra = p.Nombre;

            if (palabra.Contains("Entry, DatePicker")) {
                await Navigation.PushAsync(new Pagina1());
            } else if (palabra.Contains("CollectionView")) {
                await Navigation.PushAsync(new Pagin2());
            } else if (palabra.Contains("Pokemon")) {
                await Navigation.PushAsync(new VDatePickerD());
            }
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand Alerta => new Command<MPaginaPrincipal>(async (p) => await ProcesoAsyncrono(p));

        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion

    }
}
