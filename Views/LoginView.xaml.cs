using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ETYUTB_Orai_Jelenlet_beadando.ViewModels;

namespace ETYUTB_Orai_Jelenlet_beadando.Views
{
    /// <summary>
        /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            var viewModel = DataContext as LoginVM;
            if (viewModel != null)
            {
                viewModel.CloseRequested += ViewModel_CloseRequested;
            }
        }
        private void ViewModel_CloseRequested(object sender, EventArgs e)
        {
           (this.Parent as Window ).Close();
        }

        public void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginVM viewModel)
            {
                var passwordBox = sender as PasswordBox;
                if (passwordBox != null)
                {
                    viewModel.Password = passwordBox.Password;
                }
            }
        }
    }
}
