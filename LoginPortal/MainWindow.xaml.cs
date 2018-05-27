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
using LoginPortal.Models;
using LoginPortal.Views;

namespace LoginPortal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // User _selectedUser;
        List<User> _users = new List<User>()
        {
            
        };

        UserViewModel _userViewModel;

        public MainWindow()
        {
            //_selectedUser = _users[0];
            InitializeComponent();
            DataContext = this;
        }


        private void SelectUserDropDownList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxOfUsers = sender as ComboBox;
            var selectedUser = comboBoxOfUsers.SelectedItem as User;

            if (FirstNameTextBox != null)
            {
                FirstNameTextBox.Text = selectedUser?.FirstName;
            }
            if (LastNameTextBox != null)
            {
                LastNameTextBox.Text = selectedUser?.LastName;
            }
            if (FullNameTextBox != null)
            {
                FullNameTextBox.Text = selectedUser?.FullName; 
            }

        }
    }
}
