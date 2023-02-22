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
            if(!fullControlBtn.IsChecked.Value 
                && !rwOBtn.IsChecked.Value 
                && !rwABtn.IsChecked.Value 
                && !rwUBtn.IsChecked.Value 
                && !readOnlyBtn.IsChecked.Value)
            {
                MessageBox.Show("Access method not selected");
                return;
            }

            
            if (fullControlBtn.IsChecked.Value)
            {
                
            }
            if (rwOBtn.IsChecked.Value)
            {
                
            }
            if (rwABtn.IsChecked.Value)
            {
                
            }
            if (rwUBtn.IsChecked.Value)
            {
                
            }
            if (readOnlyBtn.IsChecked.Value)
            {
                
            }
        }
    }
}
