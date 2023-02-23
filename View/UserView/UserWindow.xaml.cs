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
using UserPermissions.Data;
using UserPermissions.Models;

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void CreateUserBtn(object sender, RoutedEventArgs e)
        {
            UserWin.Content = new CreatePage();
            userLabel.Content = string.Empty;
        }

        private void DeleteUserBtn(object sender, RoutedEventArgs e)
        {
            UserWin.Content = new DeletePage();
            userLabel.Content = string.Empty;
        }
    }
}
