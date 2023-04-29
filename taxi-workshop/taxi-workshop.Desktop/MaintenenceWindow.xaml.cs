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
using System.Windows.Shapes;
using taxi_workshop.Desktop.Fragments;
using taxi_workshop.Desktop.Helpers;

namespace taxi_workshop.Desktop
{
    /// <summary>
    /// Interaction logic for MaintenenceWindow.xaml
    /// </summary>
    public partial class MaintenenceWindow : Window
    {
        public MaintenenceWindow()
        {
            InitializeComponent();
            tabItemChangePassword.Content = new ChangePasswordControl();

            ListAllCarsListView.ItemsSource = ServiceHelper.carService.GetAll().Select(car => car.Print());
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ServiceHelper.userService.CurrentUser = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}
