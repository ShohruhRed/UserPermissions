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

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for DeletePage.xaml
    /// </summary>
    public partial class DeletePage : Page
    {
        public DeletePage()
        {
            InitializeComponent();
        }

        private void DeleteUserBtn(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;

            var userManager = new UserManager();
            var userExists = userManager.DeleteUser(username);

            if (!userExists)
            {
                MessageBox.Show($"User with the name '{username}' does not exist");
            }
            else
            {
                MessageBox.Show($"User '{username}' has been successfully deleted");
            }            

        }
    }
}
