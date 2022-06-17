using AppIntermedio369.ViewModel;
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
    public partial class Pagin2 : ContentPage
    {
        public Pagin2()
        {
            InitializeComponent();
            BindingContext = new VMPagina2(Navigation);
        }
    }
}