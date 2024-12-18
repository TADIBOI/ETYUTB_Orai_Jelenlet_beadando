using System;
using System.Windows;
using System.Windows.Input;
using ETYUTB_Orai_Jelenlet_beadando.Commands;
using ETYUTB_Orai_Jelenlet_beadando.Models;
using ETYUTB_Orai_Jelenlet_beadando.Views;

namespace ETYUTB_Orai_Jelenlet_beadando.ViewModels
{

    public class LoginVM : ViewModelBase
    {
        private User user;
       
        public ICommand LoginCommand { get; }
        public ICommand CloseWindowCommand { get; }

        public event EventHandler CloseRequested;

        public LoginVM()
        {
            user = new User();
            user.UserName = "admin"; 
            user.Password = "admin";
            LoginCommand = new RelayCommand((param) => LoggedIn(user.UserName,user.Password));
            CloseWindowCommand = new RelayCommand((param) => CloseWindow());
        }

        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void LoggedIn(object parameter1, object parameter2)
        {
            if(parameter1!=null && parameter2!=null && parameter1.ToString()=="admin" && parameter2.ToString()=="admin")
             {
                MainWindow mainWindow = new MainWindow();
                mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                mainWindow.Show();
                CloseWindow();
            }
            else
                MessageBox.Show($"Belepes nem sikerult a {parameter1} felhasznalonevvel es {parameter2} jelszoval." );
        }

        private void CloseWindow()
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}