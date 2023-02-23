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

namespace UserPermissions.View.PermissionView
{
    /// <summary>
    /// Interaction logic for AccessWindow.xaml
    /// </summary>
    public partial class AccessWindow : Window
    {
        public AccessWindow()
        {
            InitializeComponent();
        }

        private void SetAccessBtn(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            string fullPath = fullPathBtn.Text;
            if(!allowBtn.IsChecked.Value && !denyBtn.IsChecked.Value && !resetBtn.IsChecked.Value)
            {
                MessageBox.Show("No access selected", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if(!fullControlBtn.IsChecked.Value 
                && !rwOBtn.IsChecked.Value 
                && !rwABtn.IsChecked.Value 
                && !rwUBtn.IsChecked.Value 
                && !readOnlyBtn.IsChecked.Value)
            {
                MessageBox.Show("Access method not selected", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var accessControl = new AccesControl();

            if (denyBtn.IsChecked.Value)
            {
                if (fullControlBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwOBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.ReadAndExecute 
                        | System.Security.AccessControl.FileSystemRights.ExecuteFile
                        | System.Security.AccessControl.FileSystemRights.Write, 
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwABtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.Read | 
                        System.Security.AccessControl.FileSystemRights.Write, 
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwUBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.Read, 
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (readOnlyBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.Write, 
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }               
            }

            if (allowBtn.IsChecked.Value)
            {
                if (fullControlBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.FullControl, 
                        System.Security.AccessControl.AccessControlType.Allow);
                    return;
                }
                if (rwOBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.ReadAndExecute
                        | System.Security.AccessControl.FileSystemRights.ExecuteFile
                        | System.Security.AccessControl.FileSystemRights.Write,
                        System.Security.AccessControl.AccessControlType.Allow);
                    return;
                }
                if (rwABtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                       System.Security.AccessControl.FileSystemRights.Read |
                       System.Security.AccessControl.FileSystemRights.Write,
                       System.Security.AccessControl.AccessControlType.Allow);
                    return;
                }
                if (rwUBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                       System.Security.AccessControl.FileSystemRights.Read,
                       System.Security.AccessControl.AccessControlType.Allow);
                    return;

                }
                if (readOnlyBtn.IsChecked.Value)
                {
                    accessControl.AddDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.Write, 
                        System.Security.AccessControl.AccessControlType.Allow);
                    return;
                }               
            }

            if (resetBtn.IsChecked.Value)
            {
                if (fullControlBtn.IsChecked.Value)
                {
                    accessControl.RemoveDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.FullControl,
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwOBtn.IsChecked.Value)
                {
                    accessControl.RemoveDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.ReadAndExecute
                        | System.Security.AccessControl.FileSystemRights.ExecuteFile
                        | System.Security.AccessControl.FileSystemRights.Write,
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwABtn.IsChecked.Value)
                {
                    accessControl.RemoveDirectorySecurity(fullPath, username,
                       System.Security.AccessControl.FileSystemRights.Read |
                       System.Security.AccessControl.FileSystemRights.Write,
                       System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (rwUBtn.IsChecked.Value)
                {
                    accessControl.RemoveDirectorySecurity(fullPath, username,
                       System.Security.AccessControl.FileSystemRights.Read,
                       System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }
                if (readOnlyBtn.IsChecked.Value)
                {
                    accessControl.RemoveDirectorySecurity(fullPath, username,
                        System.Security.AccessControl.FileSystemRights.Write,
                        System.Security.AccessControl.AccessControlType.Deny);
                    return;
                }                
            }
        }
    }
}
