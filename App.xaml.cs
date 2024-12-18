using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ETYUTB_Orai_Jelenlet_beadando.Views;

namespace ETYUTB_Orai_Jelenlet_beadando
{
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            LoginView myUserControl = new LoginView();
            Window window = new Window();
            window.Width = 600;
            window.Height = 600;
            window.WindowStartupLocation= WindowStartupLocation.CenterScreen;
            window.Content = myUserControl;

            window.Show();

        }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }


    }
}
