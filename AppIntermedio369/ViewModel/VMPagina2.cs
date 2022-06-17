using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIntermedio369.ViewModel
{
    public class VMPagina2 : BaseViewModel
    {
        #region VARIABLES

        private string _Num1;
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            this.Navigation = navigation;
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

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand Volver => new Command(async () => await ProcesoAsyncrono());

        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion
    }
}
