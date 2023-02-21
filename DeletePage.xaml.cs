using System.Windows;
using System.Windows.Controls;

namespace UserPermissions;

public partial class DeletePage : Page
{
    public DeletePage()
    {
        InitializeComponent();
    }

    private void DeleteUserBtn_OnClickUserBTn(object sender, RoutedEventArgs e)
    {
        
    }

    private void CreateUserWbtn_OnClick(object sender, RoutedEventArgs e)
    {
        UserWindow userWindow = new UserWindow();
        userWindow.createWindowFrame.Content = userWindow;
    }
}