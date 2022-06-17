using System;
using AppIntermedio369.View;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIntermedio369.ViewModel
{
    public class VMPagina1:BaseViewModel
    {
        
        #region VARIABLES
  
        private string _Num1;
         private string _Num2;
         private string _Rep;
        private string _TipoElemento;

        #endregion

        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            this.Navigation = navigation;
        }
        #endregion

        #region OBJECTOS
        public string Num1{ 
            get => _Num1;
            set => SetValue(ref _Num1,value); 
        }

        public string Num2{
            get => _Num2;
            set => SetValue(ref _Num2,value);
        }

        public string Rep{ 
            get => _Rep;
            set => SetValue(ref _Rep, value);
        }

        private string SeleccionaTipoElementoV{ 
           // get => _TipoElemento;
            set => SetValue(ref _TipoElemento,value);  
        }
       
        public string SeleccionaTipoElementoP { 
            get => _TipoElemento;
            set { SetProperty(ref _TipoElemento, value);
                SeleccionaTipoElementoV = _TipoElemento;
            }
            
        }

        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
            await Navigation.PushAsync(new Pagin2());
        }

        public async Task ProcesoAsyncrono2()
        {
            await Navigation.PushAsync(new VDatePickerD());
        }
        public void ProcesoSimple()
        {
            Rep = $"{(Convert.ToInt32(Num1) + Convert.ToInt32(Num2))}";

        }
        #endregion

        #region COMANDOS
        public ICommand Siguiente => new Command(async () => await ProcesoAsyncrono());

        public ICommand PaginaPicker => new Command(async () => await ProcesoAsyncrono2());

        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion

    }
}
