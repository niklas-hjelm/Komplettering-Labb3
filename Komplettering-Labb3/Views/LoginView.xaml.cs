using Komplettering_Labb3.Managerrs;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Komplettering_Labb3.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            UserManager.CurrentUserChanged += UserManager_CurrentUserChanged;
        }

        private void UserManager_CurrentUserChanged()
        {
            throw new NotImplementedException();
        }

        private void LoginBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RegisterAdminBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RegisterCustomerBtn_OnClickmerBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
