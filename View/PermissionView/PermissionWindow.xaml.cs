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
using UserPermissions.Data;
using UserPermissions.Interfaces;
using UserPermissions.Models;
using UserPermissions.View.PermissionView;

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for PermissionWindow.xaml
    /// </summary>
    public partial class PermissionWindow : Window
    {
        

        public PermissionWindow()
        {
            InitializeComponent();            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentState = new PermListWindow();
            currentState.Show();
        }

        private void SetAccessBtn(object sender, RoutedEventArgs e)
        {
            var accWin = new AccessWindow();
            accWin.Show();
        }
    }
}
