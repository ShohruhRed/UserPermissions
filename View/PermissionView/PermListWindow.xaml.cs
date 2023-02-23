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

namespace UserPermissions.View.PermissionView
{
    /// <summary>
    /// Interaction logic for PermListWindow.xaml
    /// </summary>
    public partial class PermListWindow : Window
    {
        public PermListWindow()
        {
            InitializeComponent();
            var perm = GetPermissions();
            permissionList.ItemsSource = perm;
        }

        private List<Permission> GetPermissions()
        {
            try
            {
                var ac = new AccesControl();

                var perm = ac.GetPermissions();
                return perm;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            var list = new List<Permission>();
            return list;             
            
        }
    }
}
