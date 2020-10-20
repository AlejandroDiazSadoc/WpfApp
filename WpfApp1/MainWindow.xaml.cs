using MongoDB.Bson;
using MongoDB.Driver;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        

        public MainWindow()
        {
            InitializeComponent();
            
            
            
        }
        /**
         * Shutdown the application
         */
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /*
         * Minimize the window
         */
        private void Button_Minimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        /**
         * Allow to move the window.
         */
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        /**
         * Create a new object of RegisterWindow and show it in order to create a new user
         */
        private void Register(object sender, RoutedEventArgs e)
        {
            RegisterWindow register = new RegisterWindow();
            register.Show();
        }

        /**
         * Try to login the user entered
         */
        private void Login(object sender, RoutedEventArgs e)
        {
            try
            { 

                User user = DatabaseManagement.instance.Users.Find(x => x.username.Equals(User_txt.Text)).Single();
                
                if (user.password.Equals(Password_txt.Password))
                    ShowMessage(true,user);
                else
                    ShowMessage(false);

            }
            catch(Exception ex)
            {
                ShowMessage(false);
            }
        }

        /**
         * Show the dialog host content depending if the login was successful or not.
         */
        private async void ShowMessage(bool isLogged,User user=null)
        {
            if (isLogged)
            {
                Logged.IsOpen = true;
                await Task.Delay(1000);
                Logged.IsOpen = false;
                LoggedIn logged = new LoggedIn(user);
                logged.Show();
                this.Close();
            }
            else
            {
                Login_Failed.Visibility = Visibility.Visible;
                await Task.Delay(2000);
                Login_Failed.Visibility = Visibility.Collapsed;
            }



        }

    }
}
