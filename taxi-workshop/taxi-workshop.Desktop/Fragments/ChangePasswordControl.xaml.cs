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

namespace taxi_workshop.Desktop.Fragments
{
    /// <summary>
    /// Interaction logic for ChangePasswordControl.xaml
    /// </summary>
    public partial class ChangePasswordControl : UserControl
    {
        public ChangePasswordControl()
        {
            InitializeComponent();
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
