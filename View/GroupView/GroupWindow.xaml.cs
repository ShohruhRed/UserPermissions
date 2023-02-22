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
using UserPermissions.View.GroupView;

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

        private void CreateGroupBtn(object sender, RoutedEventArgs e)
        {
            GroupWin.Content = new CreateGroupPage();
        }

        private void DeleteGroupBtn(object sender, RoutedEventArgs e)
        {
            GroupWin.Content = new DeleteGroupPage();
        }
    }
}
