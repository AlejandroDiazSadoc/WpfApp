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
    /// Lógica de interacción para LoggedIn.xaml
    /// </summary>
    public partial class LoggedIn : Window
    {
        public LoggedIn()
        {
            InitializeComponent();

            HomePanel.Visibility = Visibility.Visible;

            GithubPanel.Visibility = Visibility.Hidden;

            SecondPanel.Visibility = Visibility.Hidden;
            
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        private async void Logout()
        {
            MainWindow logout = new MainWindow();
            LoggedOut.IsOpen = true;
            await Task.Delay(1000);
            LoggedOut.IsOpen = false;
            logout.Show();    
            this.Close();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GithubContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SecondPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;

            if(GithubPanel.Visibility != Visibility.Visible)
                GithubPanel.Visibility = Visibility.Visible;
        }

        private void HomeContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SecondPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;

            if(HomePanel.Visibility != Visibility.Visible)
                HomePanel.Visibility = Visibility.Visible;
            
        }

        private void SecondContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;

            if(SecondPanel.Visibility != Visibility.Visible)
                SecondPanel.Visibility = Visibility.Visible;
        }
    }
}
