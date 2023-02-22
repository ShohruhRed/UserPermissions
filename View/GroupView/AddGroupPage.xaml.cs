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

namespace UserPermissions.View.GroupView
{
    /// <summary>
    /// Interaction logic for AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
        }

        private void AddUserGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            var groupManager = new GroupManager();
            string username = userName.Text;

            var isAdded = groupManager.AddUserToGroup(username);

            if (!isAdded)
                MessageBox.Show($"There is no such user or group");
            else
                MessageBox.Show($"'{username}' has been successfully added to group");

        }
    }
}
