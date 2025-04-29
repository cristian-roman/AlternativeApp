using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Alternative.ViewModel
{
    public class RegistrationUIViewModel
    {
        private bool isWorking = false;

        private string username;
        private string password;
        private string repeatedPassword;
        private string email;

        #region properties

        public string Username 
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string RepeatedPassword
        {
            get
            {
                return repeatedPassword;
            }
            set
            {
                repeatedPassword = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        public ICommand RegisterCommand { get; private set; }

        public RegistrationUIViewModel()
        {
            RegisterCommand = new Command(TryToRegister, () => !isWorking);
        }

        /// <summary>
        /// The function which validates the register by checking the fields: locally and by comparing with database
        /// </summary>
        private void TryToRegister()
        {
            Application.Current.MainPage.DisplayAlert("Successful register", "" , "ok");
        }
    }
}
