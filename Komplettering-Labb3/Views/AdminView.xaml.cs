using System;
using System.Windows.Controls;
using Komplettering_Labb3.Managerrs;

namespace Komplettering_Labb3.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
            UserManager.CurrentUserChanged += UserManager_CurrentUserChanged;
        }

        private void UserManager_CurrentUserChanged()
        {
            throw new NotImplementedException();
        }
        
        private void ProdList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LogoutBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
