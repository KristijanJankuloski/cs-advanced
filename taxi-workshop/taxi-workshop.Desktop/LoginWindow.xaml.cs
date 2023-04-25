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
using taxi_workshop.Desktop.Helpers;
using taxi_workshop.DomainModels.Enums;

namespace taxi_workshop.Desktop
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            KeyDown += EnterKeyPressed;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ServiceHelper.userService.Login(txtUsername.Text, txtPassword.Password);
                if (ServiceHelper.userService.CurrentUser.Role == Role.Administrator)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
                else if (ServiceHelper.userService.CurrentUser.Role == Role.Manager)
                {
                    ManagerWindow managerWindow = new ManagerWindow();
                    managerWindow.Show();
                }
                else
                {
                    MaintenenceWindow maintenenceWindow = new MaintenenceWindow();
                    maintenenceWindow.Show();
                }
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EnterKeyPressed(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
