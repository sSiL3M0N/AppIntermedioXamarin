using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIntermedio369.ViewModel
{
    public class VMDatePickerD:BaseViewModel
    {
        #region VARIABLES

        DateTime _fechaSeleccioanda;
        string _fechaMostar;
        #endregion

        #region CONSTRUCTOR
        public VMDatePickerD(INavigation navigation)
        {
            this.Navigation = navigation;
            Fecha=DateTime.Now;
        }
        #endregion

        #region OBJECTOS
        
        public DateTime Fecha {
            get => _fechaSeleccioanda;
            set { SetValue(ref _fechaSeleccioanda, value); 
                FechaMostar=_fechaSeleccioanda.ToString("dd/MM/yyyy");
            }
            
        }

        public string FechaMostar { 
            get => _fechaMostar;
            set => SetValue(ref _fechaMostar,value);
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
        public ICommand Back => new Command(async () => await ProcesoAsyncrono());

        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion
    }
}
