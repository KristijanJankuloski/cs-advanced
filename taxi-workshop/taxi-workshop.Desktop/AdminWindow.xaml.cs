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
using taxi_workshop.DomainModels.Enums;
using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.Desktop
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            comboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGridUsers.ItemsSource = ServiceHelper.userService.GetAll();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ServiceHelper.userService.CurrentUser = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
        
        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            User userToDelete = (User)dataGridUsers.SelectedItem;
            ServiceHelper.userService.Remove(userToDelete.Id);
            MessageBox.Show("Selected user has been deleted", "User deleted", MessageBoxButton.OK);
            dataGridUsers.ItemsSource = ServiceHelper.userService.GetAll();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            Role userRole = (Role)comboRole.SelectedItem;
            User newUser = new User(txtUsername.Text, txtPassword.Text, userRole);
            ServiceHelper.userService.Add(newUser);
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            MessageBox.Show("User added successfully", "User Added", MessageBoxButton.OK);
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
