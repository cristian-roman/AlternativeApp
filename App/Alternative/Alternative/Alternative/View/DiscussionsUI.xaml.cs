using Alternative.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alternative.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscussionsUI : ContentPage
    {
        public DiscussionsUI()
        {
            BindingContext = new DiscussionsUIViewModel();
            InitializeComponent();
        }
    }
}