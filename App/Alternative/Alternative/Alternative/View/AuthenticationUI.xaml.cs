using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Alternative.ViewModel;

namespace Alternative.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationUI : ContentPage
    {
        public AuthenticationUI()
        {
            BindingContext = new AuthenticationUIViewModel();
            InitializeComponent();
        }
    }
}