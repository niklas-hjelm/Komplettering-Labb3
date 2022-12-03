using Komplettering_Labb3.Managerrs;
using System.Windows;

namespace Komplettering_Labb3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            UserManager.CurrentUserChanged += UserManager_CurrentUserChanged;
        }

        private void UserManager_CurrentUserChanged()
        {
            if (UserManager.IsAdminLoggedIn)
            {
                AdminTab.Visibility = Visibility.Visible;
                ShopTab.Visibility = Visibility.Visible;
                LoginTab.Visibility = Visibility.Collapsed;
            }
            else
            {
                ShopTab.Visibility = Visibility.Visible;
                AdminTab.Visibility = Visibility.Collapsed;
                LoginTab.Visibility = Visibility.Collapsed;
            }
        }
    }
}
