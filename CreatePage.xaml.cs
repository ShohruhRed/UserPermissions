﻿using System;
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

namespace UserPermissions
{
    /// <summary>
    /// Interaction logic for CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        private void CreateUserBTn(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            string password = passBox.Password;

            var userManager = new UserManager();

            var result = userManager.CreateUser(username, password);


            if (result)
            {
                MessageBox.Show($"User {username} has been created");
            }
            else
                MessageBox.Show($"User {username} is already exist");
        }
    }
}