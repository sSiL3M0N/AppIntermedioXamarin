using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIntermedio369.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VPaginaPrincipal : ContentPage
    {
        public VPaginaPrincipal()
        {
            InitializeComponent();
            BindingContext = new ViewModel.VMPaginaPrincipal(Navigation);
        }
    }
}