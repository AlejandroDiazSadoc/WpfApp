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

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void Button_Minimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (Password_txt.Password.Equals("root") && User_txt.Text.Equals("root"))
                ShowMessage(true);
            else
                ShowMessage(false);
        }

        private async void ShowMessage(bool isLogged)
        {
            if (isLogged)
            {
                Logged.IsOpen = true;
                await Task.Delay(1000);
                Logged.IsOpen = false;
                LoggedIn logged = new LoggedIn();
                logged.Show();
                this.Close();
            }
            else
            {
                Login_Failed.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                Login_Failed.Visibility = Visibility.Collapsed;
            }



        }

    }
}
