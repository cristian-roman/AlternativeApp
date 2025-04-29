using Alternative.Utilities.AuthenticationUI;
using Alternative.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Alternative.ViewModel
{
    public class AuthenticationUIViewModel : INotifyPropertyChanged
    {
        private RegistrationUI registrationPage;
        private DiscussionsUI discussionsPage;
        private bool isWorking = false;
        private string usernameField;
        private string passwordField;

        #region properties

        public string UsernameField
        {
            get
            {
                return usernameField;
            }
            set
            {
                usernameField = value;
                OnPropertyChanged();
            }
        }
       
        public string PasswordField
        {
            get
            {
                return passwordField;
            }
            set
            {
                passwordField = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string name="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));       
        }

        #endregion

        public ICommand LogInCommand { get; private set; }
        public ICommand LoadRegistrationPageCommand { get; private set; }

        public AuthenticationUIViewModel()
        {
            registrationPage = null;
            discussionsPage = null;
            LogInCommand = new Command(TryToLogIn, () => !isWorking);
            LoadRegistrationPageCommand = new Command(LoadRegistrationPage, () => !isWorking);
        }

        #region commandsFunction

        private void LoadRegistrationPage()
        {
            isWorking = true;

            if (registrationPage == null)
            {
                registrationPage = new RegistrationUI();
            }

            Application.Current.MainPage.Navigation.PushModalAsync(registrationPage);

            isWorking = false;
            
        }

        /// <summary>
        /// Initiate all checking procedures: locally and by comparing from database
        /// </summary>
        private void TryToLogIn()
        {
            isWorking = true;

            string usernameFieldMessage = AuthenticationFieldChecker.CheckUsernameFieldSpelling(usernameField);
            string passwordFieldMessage = AuthenticationFieldChecker.CheckPasswordFieldSpelling(passwordField);

            isWorking = false;

            if (discussionsPage == null)
            {
                discussionsPage = new DiscussionsUI();
            }

            Application.Current.MainPage.Navigation.PushAsync(discussionsPage);
        }

        #endregion
    }
}
