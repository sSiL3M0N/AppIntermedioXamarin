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
    public partial class VDatePickerD : ContentPage
    {
        public VDatePickerD()
        {
            InitializeComponent();
            BindingContext = new VMDatePickerD(Navigation);
        }
    }
}