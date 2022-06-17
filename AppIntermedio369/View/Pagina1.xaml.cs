using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppIntermedio369.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIntermedio369.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
            BindingContext = new VMPagina1(Navigation);
        }
    }
}