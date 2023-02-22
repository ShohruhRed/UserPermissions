using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for DeleteGroupPage.xaml
    /// </summary>
    public partial class DeleteGroupPage : Page
    {
        public DeleteGroupPage()
        {
            InitializeComponent();
        }

        private void DeleteGroupBtn(object sender, RoutedEventArgs e)
        {
            var groupManager = new GroupManager();
            string groupname = groupName.Text;

            var deletePage = groupManager.DeleteGroup(groupname);

            if (!deletePage)
                MessageBox.Show($"Group with the name '{groupname}' not exist");
            else
                MessageBox.Show($"'{groupname}' has been deleted from group'");
        }
    }
}
