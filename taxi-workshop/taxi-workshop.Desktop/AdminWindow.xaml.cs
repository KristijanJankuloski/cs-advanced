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
using taxi_workshop.Desktop.Fragments;

namespace taxi_workshop.Desktop
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private List<User> userList = ServiceHelper.userService.GetAll();
        public AdminWindow()
        {
            InitializeComponent();
            comboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>();
            dataGridUsers.ItemsSource = userList;

            tabItemChangePassword.Content = new ChangePasswordControl();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userList = ServiceHelper.userService.GetAll();
            dataGridUsers.Items.Refresh();
        }

        private void refreshItems_Click(object sender, RoutedEventArgs e)
        {
            userList = ServiceHelper.userService.GetAll();
            dataGridUsers.Items.Refresh();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ServiceHelper.userService.CurrentUser = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        private void btnDeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            User userToDelete = (User)dataGridUsers.SelectedItem;
            ServiceHelper.userService.Remove(userToDelete.Id);
            MessageBox.Show("Selected user has been deleted", "User deleted", MessageBoxButton.OK);
            userList = ServiceHelper.userService.GetAll();
            dataGridUsers.Items.Refresh();
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
    }
}
