﻿using MongoDB.Driver;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private LoggedIn windowLogged;
        public AddUser(LoggedIn window)
        {
            InitializeComponent();

            windowLogged = window;
        }

        /**
         * Close the window and reopens the logged in window.
         */
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            windowLogged.WindowState = WindowState.Normal;
        }

        /**
         * Check if already exits an user with this username and save a new user otherwise.
         */
        private void InsertUser(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = DatabaseManagement.instance.Users.Find(x => x.username.Equals(UserName_txt.Text)).Single<User>();

                ShowErrorMessage(false, "This user already exits, please change the username");


            }
            catch (Exception)
            {
                if (Password1_txt.Password.Equals(Password2_txt.Password))
                {

                    User newUser = new User()
                    {
                        username = UserName_txt.Text,
                        password = Password1_txt.Password,
                        role = RolePicker.Text,
                    };

                    DatabaseManagement.instance.Users.InsertOne(newUser);
                    ShowErrorMessage(true, "Successfully registered");
                    windowLogged.UpdateUserList();
                }
                else
                {
                    ShowErrorMessage(false, "Passwords do not match");
                }
            }


        }

        /**
         * Shows the dialog content with the message in "message" for 1 second.
         */
        private async void ShowErrorMessage(bool isLogged, String message)
        {
            AddUser_Failed_Text.Text = message;
            AddUser_Failed.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            AddUser_Failed.Visibility = Visibility.Collapsed;

            if (isLogged)
            {
                this.Close();
                windowLogged.WindowState = WindowState.Normal;
            }
        }

    }
}
