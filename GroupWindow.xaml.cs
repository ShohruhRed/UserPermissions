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

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for GroupWindow.xaml
    /// </summary>
    public partial class GroupWindow : Window
    {
        IUserManager UserManager;
        public GroupWindow()
        {
            InitializeComponent();
           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO: implemet DI
            var groupManager = new GroupManager();
            string username = textBoxMain.Text;

            var addGroup = groupManager.AddUserToGroup(username);

            if (!addGroup)
                MessageBox.Show($"User with the name '{username}' does not exist");
            else
                MessageBox.Show($"User '{username} has been added to group'");
        }
    }
}
