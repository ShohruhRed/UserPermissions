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

        private void CreateUserBTn(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            string password = passBox.Password;

            var userManager = new UserManager();

            var res1 = userManager.DeleteUser(username);

            
            var result = userManager.CreateUser(username, password);
            

            if (result)
            {
                MessageBox.Show($"User {username} has been created");
            }
            else
                MessageBox.Show("User has not been created");
        }
    }
}
