using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
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

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateUserBtn(object sender, RoutedEventArgs e)
        {
            var userWindow = new UserWindow();
            userWindow.Show();
        }

        private string GetInfo()
        {
            return "access";
        }

        private void CreateGroupBtn(object sender, RoutedEventArgs e)
        {

        }

        private void GetPermissionsBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
