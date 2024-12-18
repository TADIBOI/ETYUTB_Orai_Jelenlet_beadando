using System;
using System.Collections.Generic;
using System.Windows;
using ETYUTB_Orai_Jelenlet_beadando.Models;
using ETYUTB_Orai_Jelenlet_beadando.ViewModels;

namespace ETYUTB_Orai_Jelenlet_beadando.Views
{
  
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Cllosing;
            List<Student> Students = new List<Student>();
            Students = new List<Student>
            {
                new Student("Aranyi Aron", "TUGB8D", DateTime.Now.Subtract(new TimeSpan(0, 0, 3, 1))),
                new Student("Borsos Balazs", "6A5SDG", DateTime.Now.Subtract(new TimeSpan(0, 0, 2, 1))),
                new Student("Csoltay Cecil", "NFND9A", DateTime.Now.Subtract(new TimeSpan(0, 0, 1, 1)))
            };

            DataContext = new StudentVM(Students);
        }
        private void MainWindow_Cllosing(object sender,System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
