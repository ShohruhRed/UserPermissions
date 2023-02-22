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
    /// Interaction logic for CreateGroupPage.xaml
    /// </summary>
    public partial class CreateGroupPage : Page
    {
        public CreateGroupPage()
        {
            InitializeComponent();
        }

        private void CreateGroupBtn(object sender, RoutedEventArgs e)
        {
            //TODO: implement DI
            var groupManager = new GroupManager();
            string groupname = groupName.Text;

            var addGroup = groupManager.CreateGroup(groupname);

            if (!addGroup)
                MessageBox.Show($"Group with the name '{groupname}' is already exist");
            else
                MessageBox.Show($"Group '{groupname}' has been created'");
        }
    }
}
