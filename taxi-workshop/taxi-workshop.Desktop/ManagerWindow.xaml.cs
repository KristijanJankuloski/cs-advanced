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
using taxi_workshop.Desktop.Fragments;

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

            tabItemChangePassword.Content = new ChangePasswordControl();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ServiceHelper.userService.CurrentUser = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        private void tabControlManager_Selected(object sender, RoutedEventArgs e)
        {
            if (tabControlManager.SelectedIndex == 2)
                tabControlManager_AssignSelected();
            else if (tabControlManager.SelectedIndex == 3)
                tabControlManager_UnassignSelected();

        }

        private void tabControlManager_AssignSelected()
        {
            var availableDrivers = ServiceHelper.driverService.GetAll().Where(driver => driver.Car == null);
            assignDriverListBox.ItemsSource = availableDrivers;
            //.Select(driver => $"{driver.FirstName} {driver.LastName}")
            assignCarListBox.ItemsSource = ServiceHelper.carService.GetAll().Where(car => ServiceHelper.carService.IsCarAvailable(car));

        }

        private void tabControlManager_UnassignSelected()
        {
            var driversWithCars = ServiceHelper.driverService.GetAll().Where(driver => driver.Car != null);
            unassignDriver.ItemsSource = driversWithCars;
        }

        private void btnAssignSelectedDriver_Click(object sender, RoutedEventArgs e)
        {
            var selectedDriver = (Driver)assignDriverListBox.SelectedItem;
            var selectedCar = (Car)assignCarListBox.SelectedItem;
            ServiceHelper.driverService.AssignDriver(selectedDriver, selectedCar);
        }
    }
}
