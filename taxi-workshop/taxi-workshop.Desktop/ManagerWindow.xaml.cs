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
using taxi_workshop.Desktop.Helpers;
using taxi_workshop.Desktop.Models;
using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.Desktop
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private List<Driver> driverList = ServiceHelper.driverService.GetAll();
        private List<DriverLicenseDisplay> driverLicenseDisplays;
        public ManagerWindow()
        {
            InitializeComponent();
            dataGridListDrivers.ItemsSource = driverList;
            driverLicenseDisplays = new List<DriverLicenseDisplay>();
            foreach(Driver driver in driverList)
            {
                DriverLicenseDisplay display = new DriverLicenseDisplay(driver.FirstName, driver.LastName, driver.Shift, driver.License, driver.LicenseExpieryDate, driver.IsLicenseExpiered());
                driverLicenseDisplays.Add(display);
            }
            dataGridDriverLicense.ItemsSource = driverLicenseDisplays;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ServiceHelper.userService.CurrentUser = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if (txtNewPwd.Password == string.Empty)
            {
                MessageBox.Show("New password is empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (txtNewPwd.Password != txtRepeatPwd.Password)
            {
                MessageBox.Show("Repeated passwrods do not match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (txtOldPwd.Password == txtNewPwd.Password)
            {
                MessageBox.Show("New password cannot match old password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!ServiceHelper.userService.ChangePassword(txtOldPwd.Password, txtNewPwd.Password))
            {
                MessageBox.Show("Old password is incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show("Your password has been updated", "Password changed");
            txtOldPwd.Password = string.Empty;
            txtNewPwd.Password = string.Empty;
            txtRepeatPwd.Password = string.Empty;
        }
    }
}
