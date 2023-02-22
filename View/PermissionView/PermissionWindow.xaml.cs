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
            var perm = GetPermissions();
            permissionList.ItemsSource = perm;
        }
      
        private List<Permission> GetPermissions()
        {
            var ac = new AccesControl();

            var perm = ac.GetPermissions();

            return perm;
        }
    }
}
